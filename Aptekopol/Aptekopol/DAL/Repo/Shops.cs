using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Aptekopol.DAL.Repo
{
    using Entities;
    internal class Shops
    {
        #region Queries
        private const string GET_ALL_SHOPS = "SELECT * FROM `shops`";
        private const string GET_ALL_CONTRACTS = "SELECT * FROM `contracts` WHERE `shop_id` LIKE ";
        private const string INSERT_INTO_SHOPS = "INSERT INTO `shops`(`City`, `Address`, `Phone`, `Email`) VALUES ";
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

        public static List<Contract> GetAllContractsByShop(Shop shop)
        {
            List<Contract> contracts = new List<Contract>();
            using (var connection = DBConnection.Instance.Connection)
            {
                MySqlCommand command = new MySqlCommand($"{GET_ALL_CONTRACTS} {shop.ID}", connection);
                connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                    contracts.Add(new Contract(reader));

                connection.Close();
            }
            return contracts;
        }

        // Dodanie nowego sklepu do BD
        public static bool AddShop(Shop shop)
        {
            bool status = false;
            try
            {
                using (var connection = DBConnection.Instance.Connection)
                {
                    MySqlCommand command = new MySqlCommand($"{INSERT_INTO_SHOPS} {shop.ToInsert()}", connection);
                    connection.Open();

                    var id = command.ExecuteNonQuery();
                    status = true;
                    shop.ID = (sbyte)command.LastInsertedId;
                    connection.Close();
                }
            }
            catch { System.Windows.MessageBox.Show("Błąd"); }

            return status;
        }

        // Edycja istniejącego sklepu
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

        // Usunięcie sklepu z BD
        public static bool DelShop(Shop shop)
        {
            bool status = false;

            using (var connection = DBConnection.Instance.Connection)
            {
                string DEL_SHOP = $"DELETE FROM `shops` WHERE id LIKE {shop.ID}";

                MySqlCommand command = new MySqlCommand(DEL_SHOP, connection);
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
