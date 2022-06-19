using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Aptekopol.DAL.Repo
{
    using Entities;
    internal class Orders
    {
        //logika dla tych foreigh id mnie przerasta 
        #region Queries
        private const string GET_ALL_CLIENTS = "SELECT * FROM `clients`";
        private const string GET_ALL_SHOPS = "SELECT * FROM `shops`";
        private const string GET_ALL_WORKERS = "SELECT * FROM `workers`";
        private const string GET_ALL_PRODUCTS = "SELECT * FROM `products`";
        private const string GET_ALL_ORDERS = "SELECT * FROM `orders` ";
        private const string INSERT_INTO_SHOPS = "INSERT INTO `shops`(`City`, `Address`, `Phone`, `Email`) VALUES ";
        private const string INSERT_INTO_ORDERS = "INSERT INTO `orders`(`Order_ID`, `Client_ID`, `Shop_ID`, `Worker_ID`, `Product_ID`, `Quantity`, `Order_date`) VALUES ";
        //private const string INSERT_INTO_SHOPS
        //private const string INSERT_INTO_SHOPS
        //private const string INSERT_INTO_SHOPS
        #endregion


        #region CRUD
        // Pobranie wszystkich sklepów z DB i stworzenie z nich listy
        public static List<Shop> GetAllShops()
        {
            List<Shop> shops = new List<Shop>();
            using (var connection = DBConnection.Instance.Connection)
            {
                MySqlCommand command = new MySqlCommand(GET_ALL_SHOPS, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                    shops.Add(new Shop(reader));
                connection.Close();
            }
            return shops;
        }

        public static List<Order> GetAllOrders()
        {
            List<Order> orders = new List<Order>();
            using (var connection = DBConnection.Instance.Connection)
            {
                MySqlCommand command = new MySqlCommand(GET_ALL_ORDERS, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                    orders.Add(new Order(reader));
                connection.Close();
            }
            return orders;
        }
        public static Shop GetShopByID(int id)
        {
            Shop shop = null;
            using (var connection = DBConnection.Instance.Connection)
            {
                string UPDATE_SHOP = $" WHERE ID LIKE {id}";
                MySqlCommand command = new MySqlCommand($"{GET_ALL_SHOPS} {UPDATE_SHOP}", connection);
                connection.Open();
                var reader = command.ExecuteReader();
                shop = new Shop(reader);
                connection.Close();
            }
            return shop;
        }
        public static List<Order> GetAllOrdersByShop(Shop shop)
        {
            List<Order>orders = new List<Order>();
            using (var connection = DBConnection.Instance.Connection)
            {
                MySqlCommand command = new MySqlCommand($"{GET_ALL_ORDERS} {shop.ID}", connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                    orders.Add(new Order(reader));
                connection.Close();
            }
            return orders;
        }
        // Dodanie nowego sklepu do BD
        public static bool AddOrder(Order order)
        {
            bool status = false;
            using (var connection = DBConnection.Instance.Connection)
            {
                MySqlCommand command = new MySqlCommand($"{INSERT_INTO_ORDERS} {order.ToInsert()}", connection);
                connection.Open();
                var id = command.ExecuteNonQuery();
                status = true;
                order.Order_ID = (sbyte)command.LastInsertedId;
                connection.Close();
            }
            return status;
        }
        // Edycja istniejącego
        public static bool EditShop(Shop shop, int shopID)
        {
            bool status = false;
            using (var connection = DBConnection.Instance.Connection)
            {
                string UPDATE_SHOP = $"UPDATE `shops` SET " +
                    $"`City`='{shop.City}'," +
                    $"`Address`='{shop.Address}'," +
                    $"`Phone`='{shop.Phone}'," +
                    $"`Email`='{shop.Email}'" +
                    $" WHERE ID LIKE {shopID}";
                MySqlCommand command = new MySqlCommand(UPDATE_SHOP, connection);
                connection.Open();
                var n = command.ExecuteNonQuery();
                if (n == 1) status = true;
                connection.Close();
            }
            return status;
        }
        // Usunięcie z BD
        public static bool DelShop(Shop shop)
        {
            bool status = false;
            using (var connection = DBConnection.Instance.Connection)
            {
                string DEL_SHOP = $"DELETE FROM `shops` WHERE id LIKE {shop.ID}";
                MySqlCommand command = new MySqlCommand(DEL_SHOP, connection);
                connection.Open();
                var n = command.ExecuteNonQuery();
                if (n == 1) status = true;
                connection.Close();
            }
            return status;
        }
        #endregion
    }
}