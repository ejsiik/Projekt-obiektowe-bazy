using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Aptekopol.DAL.Views
{
    using Entities;

    internal class ProductsSuppliers
    {
        #region Queries
        private const string GET_ALL = "SELECT * FROM `productssuppliers`";
        #endregion

        #region CRUD
        // Pobranie wszystkich z DB i stworzenie z nich listy
        public static List<ProductSupplier> GetAllProductsSuppliers()
        {
            List<ProductSupplier> productsSuppliers = new List<ProductSupplier>();
            using (var connection = DBConnection.Instance.Connection)
            {
                MySqlCommand command = new MySqlCommand(GET_ALL, connection);
                connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                    productsSuppliers.Add(new ProductSupplier(reader));

                connection.Close();
            }
            return productsSuppliers;
        }
        #endregion
    }
}
