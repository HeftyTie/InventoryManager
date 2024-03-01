using System;
using System.Configuration;
using System.Data.SQLite;
using System.Windows.Forms;

namespace InventoryManager
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Initialize the database
            InitializeDatabase();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main_Screen());
        }

        static void InitializeDatabase()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Inventory"].ConnectionString;
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string createTableQuery = "CREATE TABLE IF NOT EXISTS YourTable (Id INTEGER PRIMARY KEY, Name TEXT, Quantity INTEGER)";
                using (SQLiteCommand command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
