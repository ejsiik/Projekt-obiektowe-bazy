using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Aptekopol.DAL.Views
{
    using Entities;

    internal class OrdersView
    {
        #region Queries
        private const string GET_ALL = "SELECT * FROM `ordersview`";
        #endregion

        #region CRUD
        // Pobranie wszystkich z DB i stworzenie z nich listy
        public static List<OrderView> GetAllOrdersView()
        {
            List<OrderView> ordersView = new List<OrderView>();
            using (var connection = DBConnection.Instance.Connection)
            {
                MySqlCommand command = new MySqlCommand(GET_ALL, connection);
                connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                    ordersView.Add(new OrderView(reader));

                connection.Close();
            }
            return ordersView;
        }
        #endregion
    }
}
