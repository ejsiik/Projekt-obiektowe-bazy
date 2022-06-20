using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Aptekopol.DAL.Repo
{
    using Entities;
    internal class Products
    {
        #region Queries
        private const string GET_ALL_PRODUCTS = "SELECT * FROM `Products`";
        private const string INSERT_INTO_PRODUCTS = "INSERT INTO `Products`(`Name`, `Description`, `Price`, `Remarks`, `Category`) VALUES ";
        #endregion

        #region CRUD
        // Pobranie wszystkich produktów z DB i stworzenie z nich listy
        public static List<Product> GetAllProducts()
        {
            List<Product> Products = new List<Product>();
            using (var connection = DBConnection.Instance.Connection)
            {
                MySqlCommand command = new MySqlCommand(GET_ALL_PRODUCTS, connection);
                connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                    Products.Add(new Product(reader));

                connection.Close();
            }
            return Products;
        }

        // Dodanie nowego produktu do BD
        public static bool AddProduct(Product Product)
        {
            bool status = false;

            using (var connection = DBConnection.Instance.Connection)
            {
                MySqlCommand command = new MySqlCommand($"{INSERT_INTO_PRODUCTS} {Product.ToInsert()}", connection);
                connection.Open();

                var id = command.ExecuteNonQuery();
                status = true;
                Product.ID = (sbyte)command.LastInsertedId;
                connection.Close();
            }

            return status;
        }

        // Edycja istniejącego sklepu
        public static bool EditProduct(Product Product, int ProductID)
        {
            bool status = false;

            using (var connection = DBConnection.Instance.Connection)
            {
                string UPDATE_PRODUCT = $"UPDATE `Products` SET " +
                    $"`Name`='{Product.Name}'," +
                    $"`Description`='{Product.Description}'," +
                    $"`Price`='{Product.Price}'," +
                    $"`Remarks`='{Product.Remarks}'," +
                    $"`Category`='{Product.Category}'" +
                    $" WHERE ID LIKE {ProductID}";

                MySqlCommand command = new MySqlCommand(UPDATE_PRODUCT, connection);
                connection.Open();

                try
                {
                    var n = command.ExecuteNonQuery();
                    if (n == 1) status = true;
                }
                catch
                {
                    status = false;
                }

                connection.Close();
            }

            return status;
        }

        // Usunięcie produktu z BD
        public static bool DelProduct(Product Product)
        {
            bool status = false;

            using (var connection = DBConnection.Instance.Connection)
            {
                string DEL_PRODUCT = $"DELETE FROM `Products` WHERE id LIKE {Product.ID}";

                MySqlCommand command = new MySqlCommand(DEL_PRODUCT, connection);
                connection.Open();

                try
                {
                    var n = command.ExecuteNonQuery();
                    if (n == 1) status = true;
                }
                catch
                {
                    status = false;
                }

                connection.Close();
            }

            return status;
        }
        #endregion
    }
}
