using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;
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

        public BindingList<Product> Products { get; set; }
        public BindingList<Part> AllParts { get; set; }

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
            return false;
        }

        public Product LookupProduct(int productId)
        {
            return null; 
        }

        public void UpdateProduct(int productId, Product product) 
        {
            string sqlQuery = "UPDATE Product SET " +
                      "Name = @Name, " +
                      "InStock = @InStock, " +
                      "Price = @Price, " +
                      "Min = @Min, " +
                      "Max = @Max, " +
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
            using (var _connection = new SQLiteConnection("Data Source=Data/Inventory.db;Version=3;"))
            {
                _connection.Open();

                using (var transaction = _connection.BeginTransaction())
                {
                    string deleteSql = "DELETE FROM [Part] WHERE PartID = @partID";
                    string updateSql = "UPDATE [Part] SET PartID = PartID - 1 WHERE PartID > @deletedPartID";

                    using (var command = new SQLiteCommand(deleteSql, _connection))
                    {
                        command.Parameters.AddWithValue("@partID", part.PartID);
                        command.ExecuteNonQuery();

                        using (var updateCommand = new SQLiteCommand(updateSql, _connection))
                        {
                            updateCommand.Parameters.AddWithValue("@deletedPartID", part.PartID);
                            updateCommand.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                }
            }
            return true; 
        }

        public Part LookupPart(int partId)
        {
            return null;
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
    }
}
