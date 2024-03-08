using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Classes
{
    public class Inventory
    {
        readonly Methods methods = new Methods();

        public BindingList<Product> Products { get; set; } = new BindingList<Product>();
        public BindingList<Part> AllParts { get; } = new BindingList<Part>();

        public void AddProduct(Product product)
        {
            string sqlQuery = "INSERT INTO [Product] " +
                                "(Name, InStock, Price, Min, Max) " +
                                "VALUES " +
                                "(@Name, @InStock, @Price, @Min, @Max)";
            methods.ProductInventoryManager(sqlQuery, product);
        }

        public bool RemoveProduct(int productId)
        {
            using (var connection = new SQLiteConnection("Data Source=Data/Inventory.db;Version=3;"))
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction())
                {
                    string sql = @"
                    DELETE FROM [Product] 
                    WHERE ProductID = @productID;

                    UPDATE [Product] 
                    SET ProductID = ProductID - 1 
                    WHERE ProductID > @deletedProductID;";

                    using (var command = new SQLiteCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@productID", productId);
                        command.Parameters.AddWithValue("@deletedProductID", productId);
                        command.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
            }

            return true;
        }

        public Product LookupProduct(int productId)
        {
            Product product = null; 

            using (var connection = new SQLiteConnection("Data Source=Data/Inventory.db;Version=3;"))
            {
                connection.Open();

                string sql = @"
                            SELECT * 
                            FROM [Product] 
                            WHERE ProductID = @productID";

                using (var command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@productID", productId); 

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            product = new Product
                            {
                                ProductID = Convert.ToInt32(reader["ProductID"]),
                                Name = reader["Name"].ToString(),
                                Price = Convert.ToDecimal(reader["Price"]),
                                InStock = Convert.ToInt32(reader["InStock"]),
                                Min = Convert.ToInt32(reader["Min"]),
                                Max = Convert.ToInt32(reader["Max"])
                            };
                        }
                    }
                }
            }
            return product;
        }


        public void UpdateProduct(int productId, Product product) 
        {
            string sqlQuery = "UPDATE Product SET " +
                              "Name = @Name, " +
                              "InStock = @InStock, " +
                              "Price = @Price, " +
                              "Min = @Min, " +
                              "Max = @Max " + 
                              $"WHERE ProductID = {productId}";

            methods.ProductInventoryManager(sqlQuery, product);
        }

        public void AddPart(Part part) 
        {
            string sqlQuery = "INSERT INTO [Part] " +
                    "(Name, InStock, Price, Min, Max, MachineID, CompanyName) " +
                    "VALUES " +
                    "(@Name, @InStock, @Price, @Min, @Max, @MachineID, @CompanyName)";

            methods.PartInventoryManager(sqlQuery, part);
        }

        public bool DeletePart(Part part)
        {
            using (var connection = new SQLiteConnection("Data Source=Data/Inventory.db;Version=3;"))
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction())
                {
                    string sql = @"
                    DELETE FROM [Part] 
                    WHERE PartID = @partID;

                    UPDATE [Part] 
                    SET PartID = PartID - 1 
                    WHERE PartID > @deletedPartID;";

                    using (var command = new SQLiteCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@partID", part.PartID);
                        command.Parameters.AddWithValue("@deletedPartID", part.PartID);
                        command.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
            }

            return true;
        }


        public Part LookupPart(int partId)
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
                    command.Parameters.AddWithValue("@partID", partId);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal("MachineID")))
                            {
                                part = new Inhouse
                                {
                                    PartID = partId,
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
                                    PartID = partId,
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


        public void UpdatePart(int partId, Part part)
        {
            string sqlQuery = "UPDATE Part SET " +
                              "Name = @Name, " +
                              "InStock = @InStock, " +
                              "Price = @Price, " +
                              "Min = @Min, " +
                              "Max = @Max, " +
                              "MachineID = @MachineID, " +
                              "CompanyName = @CompanyName " +
                              $"WHERE PartID = {partId}";

            methods.PartInventoryManager(sqlQuery, part);
        }

        public void PopulatePartsFromDatabase()
        {
            AllParts.Clear();
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
                                AllParts.Add(part);
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
                                AllParts.Add(part);
                            }
                        }
                    }
                }
            }
        }

        public void PopulateProductsFromDatabase()
        {
            Products.Clear();
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
                            Products.Add(product);
                        }
                    }
                }
            }
        }
    }
}
