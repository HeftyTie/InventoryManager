using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManager.Classes
{
    public class Product
    {
        public BindingList<Part> AssociatedParts { get; set; }
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public Product()
        {
            AssociatedParts = new BindingList<Part>();
        }

        public void AddAssociatedPart(Part part)
        {
            // Check if a part with the same PartID already exists
            bool partExists = AssociatedParts.Any(p => p.PartID == part.PartID);

            if (!partExists)
            {
                AssociatedParts.Add(part);
            }
        }

        public bool RemoveAssociatedPart(int partID)
        {
            // Check if a part with the specified PartID exists in the AssociatedParts list
            Part partToRemove = AssociatedParts.FirstOrDefault(p => p.PartID == partID);

            if (partToRemove != null)
            {
                AssociatedParts.Remove(partToRemove);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Part LookupAssociatedPart(int partID)
        {
            Part part = null;

            using (var connection = new SQLiteConnection("Data Source=Data/Inventory.db;Version=3;"))
            {
                connection.Open();

                string sql = @"
                    SELECT * 
                    FROM [Part] 
                    WHERE PartID = @partID";

                using (var command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@partID", partID);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal("MachineID")))
                            {
                                part = new Inhouse
                                {
                                    PartID = partID,
                                    Name = reader["Name"].ToString(),
                                    Price = Convert.ToDecimal(reader["Price"]),
                                    InStock = Convert.ToInt32(reader["InStock"]),
                                    Min = Convert.ToInt32(reader["Min"]),
                                    Max = Convert.ToInt32(reader["Max"]),
                                    MachineID = Convert.ToInt32(reader["MachineID"])
                                };
                            }
                            else if (!reader.IsDBNull(reader.GetOrdinal("CompanyName")))
                            {
                                part = new Outsourced
                                {
                                    PartID = partID,
                                    Name = reader["Name"].ToString(),
                                    Price = Convert.ToDecimal(reader["Price"]),
                                    InStock = Convert.ToInt32(reader["InStock"]),
                                    Min = Convert.ToInt32(reader["Min"]),
                                    Max = Convert.ToInt32(reader["Max"]),
                                    CompanyName = reader["CompanyName"].ToString()
                                };
                            }
                        }
                    }
                }
            }
            return part;
        }

        public void SaveAssociatedPartsToDB(int productID, string productName)
        {
            foreach (var associatedPart in AssociatedParts)
            {
                if (!IsPartAlreadyAssociated(productID, associatedPart.PartID))
                {
                    using (var connection = new SQLiteConnection("Data Source=Data/Inventory.db;Version=3;"))
                    {
                        connection.Open();
                        string sql = @"INSERT INTO AssociatedParts (ProductID, PartID) VALUES (@ProductID, @PartID)";

                        using (var command = new SQLiteCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@ProductID", productID);
                            command.Parameters.AddWithValue("@PartID", associatedPart.PartID);
                            command.ExecuteNonQuery();
                        }
                    }
                }
                else
                {
                    MessageBox.Show($"Part {associatedPart.PartID}: {associatedPart.Name} is already associated with {productName}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private bool IsPartAlreadyAssociated(int productID, int partID)
        {
            using (var connection = new SQLiteConnection("Data Source=Data/Inventory.db;Version=3;"))
            {
                connection.Open();
                string sql = @"SELECT COUNT(*) FROM AssociatedParts WHERE ProductID = @ProductID AND PartID = @PartID";

                using (var command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@ProductID", productID);
                    command.Parameters.AddWithValue("@PartID", partID);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }
    }
}
