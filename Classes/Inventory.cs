using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Classes
{
    public class Inventory
    {
        private readonly string _connectionString;
        public BindingList<Product> Products { get; set; }
        public BindingList<Part> AllParts { get; set; }

        public Inventory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void AddProduct(Product product)
        {
            string insertSql = @"
                INSERT INTO Product (Name, Price, InStock, Min, Max)
                VALUES (@Name, @Price, @InStock, @Min, @Max);
                SELECT last_insert_rowid();";

            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                using (var command = new SQLiteCommand(insertSql, connection))
                {
                    command.Parameters.AddWithValue("@Name", product.Name);
                    command.Parameters.AddWithValue("@Price", product.Price);
                    command.Parameters.AddWithValue("@InStock", product.InStock);
                    command.Parameters.AddWithValue("@Min", product.Min);
                    command.Parameters.AddWithValue("@Max", product.Max);

                    // Retrieve the last inserted row's ID
                    int productId = Convert.ToInt32(command.ExecuteScalar());
                    product.ProductID = productId;
                }
            }

        }

        public bool RemoveProduct(int productId)
        {
            return false;
        }

        public Product LookupProduct(int productId)
        {
            return null; 
        }
        public void UpdateProduct(int  productId, Product product) { }

        public void AddPart(Part part) { }

        public bool DeletePart(Part part)
        {
            return true; 
        }

        public Part LookupPart(int partId)
        {
            return null;
        }
        public void UpdatePart(int partId, Part part)
        {

        }

    }
}
