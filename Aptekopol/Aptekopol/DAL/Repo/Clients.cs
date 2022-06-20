using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Aptekopol.DAL.Repo
{
    using Entities;
    internal class Clients
    {
        #region Queries
        private const string GET_ALL_CLIENTS = "SELECT * FROM `clients`";
        private const string INSERT_INTO_CLIENTS = "INSERT INTO `clients`(`Login`, `Firstname`, `Surname`, `Is_company`, `Name`, " +
            "`NIP`, `City`, `Address`, `Phone`, `Email`, `Password`, `Password_last_change`) VALUES ";
        #endregion

        #region CRUD
        // Pobranie wszystkich klientów z DB i stworzenie z nich listy
        public static List<Client> GetAllClients()
        {
            List<Client> clients = new List<Client>();
            using (var connection = DBConnection.Instance.Connection)
            {
                MySqlCommand command = new MySqlCommand(GET_ALL_CLIENTS, connection);
                connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                    clients.Add(new Client(reader));

                connection.Close();
            }
            return clients;
        }

        public static Client GetClientByID(int id)
        {
            Client client = null;
            using (var connection = DBConnection.Instance.Connection)
            {
                string UPDATE = $" WHERE ID LIKE {id}";

                MySqlCommand command = new MySqlCommand($"{GET_ALL_CLIENTS} {UPDATE}", connection);
                connection.Open();

                var reader = command.ExecuteReader();
                client = new Client(reader);

                connection.Close();
            }
            return client;
        }

        // Dodanie nowego klienta do BD
        public static bool AddClient(Client client)
        {
            bool status = false;

            using (var connection = DBConnection.Instance.Connection)
            {
                MySqlCommand command = new MySqlCommand($"{INSERT_INTO_CLIENTS} {client.ToInsert()}", connection);
                connection.Open();

                var id = command.ExecuteNonQuery();
                status = true;
                client.ID = (sbyte)command.LastInsertedId;
                connection.Close();
            }

            return status;
        }

        // Edycja istniejącego klienta
        public static bool EditClient(Client client, int clientID)
        {
            bool status = false;

            using (var connection = DBConnection.Instance.Connection)
            {
                string UPDATE_CLIENT = $"UPDATE `clients` SET " +
                    $"`Login`='{client.Login}'," +
                    $"`Firstname`='{client.Firstname}'," +
                    $"`Surname`='{client.Surname}'," +
                    $"`Is_company`={(client.IsCompany ? 1 : 0)}," +
                    $"`Name`='{client.Name ?? (object)DBNull.Value}'," +
                    $"`NIP`='{client.NIP ?? (object)DBNull.Value}'," +
                    $"`City`='{client.City ?? (object)DBNull.Value}'," +
                    $"`Address`='{client.Address ?? (object)DBNull.Value}'," +
                    $"`Phone`='{client.Phone ?? (object)DBNull.Value}'," +
                    $"`Email`='{client.Email ?? (object)DBNull.Value}'," +
                    $"`Password`='{client.Password}'," +
                    $"`Password_last_change`='{client.PasswordLastChange.ToString("yyyy/MM/dd HH:mm:ss")}'" +
                    $" WHERE `ID` LIKE {clientID}";

                MySqlCommand command = new MySqlCommand(UPDATE_CLIENT, connection);
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

        // Usunięcie klienta z BD
        public static bool DelClient(Client client)
        {
            bool status = false;

            using (var connection = DBConnection.Instance.Connection)
            {
                string DEL_CLIENT = $"DELETE FROM `clients` WHERE id LIKE {client.ID}";

                MySqlCommand command = new MySqlCommand(DEL_CLIENT, connection);
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
