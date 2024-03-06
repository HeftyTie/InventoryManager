using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Classes
{
    public class Methods
    {
        public List<Part> PopulatePartsDataGridView()
        {
            List<Part> parts = new List<Part>();

            string connectionString = "Data Source=Data/Inventory.db;Version=3;";
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string selectSql = "SELECT * FROM [Part]";
                using (var command = new SQLiteCommand(selectSql, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader["MachineId"] != DBNull.Value)
                            {
                                // It's an in-house part
                                var part = new Inhouse
                                {
                                    PartID = Convert.ToInt32(reader["PartID"]),
                                    Name = reader["Name"].ToString(),
                                    Price = Convert.ToDecimal(reader["Price"]),
                                    InStock = Convert.ToInt32(reader["InStock"]),
                                    Min = Convert.ToInt32(reader["Min"]),
                                    Max = Convert.ToInt32(reader["Max"]),
                                    MachineID = Convert.ToInt32(reader["MachineId"]),
                                };
                                parts.Add(part);
                            }
                            else
                            {
                                // It's an outsourced part
                                var part = new Outsourced
                                {
                                    PartID = Convert.ToInt32(reader["PartID"]),
                                    Name = reader["Name"].ToString(),
                                    Price = Convert.ToDecimal(reader["Price"]),
                                    InStock = Convert.ToInt32(reader["InStock"]),
                                    Min = Convert.ToInt32(reader["Min"]),
                                    Max = Convert.ToInt32(reader["Max"]),
                                    CompanyName = reader["CompanyName"].ToString(),
                                };
                                parts.Add(part);
                            }
                        }
                    }
                }
            }
            return parts;
        }

        public List<Product> PopulateProductsDataGridView()
        {
            List<Product> products = new List<Product>();

            string connectionString = "Data Source=Data/Inventory.db;Version=3;";
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string selectSql = "SELECT * FROM [Product]";
                using (var command = new SQLiteCommand(selectSql, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var product = new Product
                            {
                                ProductID = Convert.ToInt32(reader["ProductID"]),
                                Name = reader["Name"].ToString(),
                                Price = Convert.ToDecimal(reader["Price"]),
                                InStock = Convert.ToInt32(reader["InStock"]),
                                Min = Convert.ToInt32(reader["Min"]),
                                Max = Convert.ToInt32(reader["Max"]),
                            };
                            products.Add(product);
                        }
                    }
                }
            }
            return products;
        }
    }
}
