using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public void PartInventoryManager(string sqlQuery, Part part)
        {
            using (var _connection = new SQLiteConnection("Data Source=Data/Inventory.db;Version=3;"))
            {
                _connection.Open();

                using (var command = new SQLiteCommand(sqlQuery, _connection))
                {
                    command.Parameters.AddWithValue("@Name", part.Name);
                    command.Parameters.AddWithValue("@InStock", part.InStock);
                    command.Parameters.AddWithValue("@Price", part.Price);
                    command.Parameters.AddWithValue("@Min", part.Min);
                    command.Parameters.AddWithValue("@Max", part.Max);

                    if (part is Inhouse inhousePart)
                    {
                        command.Parameters.AddWithValue("@MachineID", inhousePart.MachineID);
                        command.Parameters.AddWithValue("@CompanyName", DBNull.Value);
                    }
                    else if (part is Outsourced outsourcedPart)
                    {
                        command.Parameters.AddWithValue("@MachineID", DBNull.Value);
                        command.Parameters.AddWithValue("@CompanyName", outsourcedPart.CompanyName);
                    }

                    command.ExecuteNonQuery();
                }
            }

        }

        public void ProductInventoryManager(string sqlQuery, Product product)
        {
            using (var _connection = new SQLiteConnection("Data Source=Data/Inventory.db;Version=3;"))
            {
                _connection.Open();

                using (var command = new SQLiteCommand(sqlQuery, _connection))
                {
                    command.Parameters.AddWithValue("@Name", product.Name);
                    command.Parameters.AddWithValue("@InStock", product.InStock);
                    command.Parameters.AddWithValue("@Price", product.Price);
                    command.Parameters.AddWithValue("@Min", product.Min);
                    command.Parameters.AddWithValue("@Max", product.Max);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void PopulateUserInputFields(string request, int ID, List<TextBox> textBox, Label label)
        {
            using (var _connection = new SQLiteConnection("Data Source=Data/Inventory.db;Version=3;"))
            {
                _connection.Open();

                string selectSql;

                if (request.Split(' ')[0] == "Add")
                {
                    selectSql = $"SELECT MAX({request.Split(' ')[1] + "ID"}) FROM {request.Split(' ')[1]}";
                    using (var command = new SQLiteCommand(selectSql, _connection))
                    {
                        var maxPartId = command.ExecuteScalar();
                        int partId = maxPartId == DBNull.Value ? 1 : Convert.ToInt32(maxPartId) + 1;
                        textBox[0].Text = partId.ToString();
                    }
                    label.Text = request;
                }
                else if (request.Split(' ')[0] == "Modify")
                {
                    selectSql = $"SELECT * FROM [{request.Split(' ')[1]}] WHERE {request.Split(' ')[1] + "ID"} = {ID}";
                    using (var command = new SQLiteCommand(selectSql, _connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                textBox[0].Text = reader.GetInt32(reader.GetOrdinal($"{request.Split(' ')[1] + "ID"}")).ToString();
                                textBox[1].Text = reader.GetString(reader.GetOrdinal("Name"));
                                textBox[2].Text = reader["InStock"] == DBNull.Value ? "" : reader["InStock"].ToString();
                                textBox[3].Text = reader.GetDecimal(reader.GetOrdinal("Price")).ToString();
                                textBox[4].Text = reader.GetInt32(reader.GetOrdinal("Max")).ToString();
                                textBox[5].Text = reader.GetInt32(reader.GetOrdinal("Min")).ToString();

                                if (textBox.Count >= 8)
                                {
                                    if (reader["MachineID"] != DBNull.Value)
                                    {
                                        textBox[7].Text = reader["MachineID"].ToString();
                                    }
                                    else if (!string.IsNullOrEmpty(reader["CompanyName"].ToString()))
                                    {
                                        textBox[7].Text = reader["CompanyName"].ToString();
                                    }
                                }
                            }
                        }
                    }
                    label.Text = request;
                }
            }
        }





    }
}