using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Aptekopol.DAL.Repo
{
    using Entities;
    internal class Workers
    {
        #region Queries
        private const string GET_ALL_WORKERS = "SELECT * FROM `workers`";
        private const string INSERT_INTO_WORKERS = "INSERT INTO `workers`(`Firstname`, `Surname`, `City`, `Address`, `Phone`, `Email`, `PESEL`) VALUES ";
        #endregion

        #region CRUD
        // Pobranie wszystkich pracowników z DB i stworzenie z nich listy
        public static List<Worker> GetAllWorkers()
        {
            List<Worker> workers = new List<Worker>();
            using (var connection = DBConnection.Instance.Connection)
            {
                MySqlCommand command = new MySqlCommand(GET_ALL_WORKERS, connection);
                connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                    workers.Add(new Worker(reader));

                connection.Close();
            }
            return workers;
        }

        public static Worker GetWorkerByID(int id)
        {
            Worker worker = null;
            using (var connection = DBConnection.Instance.Connection)
            {
                string UPDATE = $" WHERE ID LIKE {id}";

                MySqlCommand command = new MySqlCommand($"{GET_ALL_WORKERS} {UPDATE}", connection);
                connection.Open();

                var reader = command.ExecuteReader();
                worker = new Worker(reader);

                connection.Close();
            }
            return worker;
        }

        // Dodanie nowego pracownika do BD
        public static bool AddWorker(Worker worker)
        {
            bool status = false;

            using (var connection = DBConnection.Instance.Connection)
            {
                MySqlCommand command = new MySqlCommand($"{INSERT_INTO_WORKERS} {worker.ToInsert()}", connection);
                connection.Open();

                var id = command.ExecuteNonQuery();
                status = true;
                worker.ID = (sbyte)command.LastInsertedId;
                connection.Close();
            }

            return status;
        }

        // Edycja istniejącego pracownika
        public static bool EditWorker(Worker worker, int workerID)
        {
            bool status = false;

            using (var connection = DBConnection.Instance.Connection)
            {
                string UPDATE_WORKER = $"UPDATE `workers` SET " +
                    $"`Firstname`='{worker.Firstname}'," +
                    $"`Surname`='{worker.Surname}'," +
                    $"`City`='{worker.City}'," +
                    $"`Address`='{worker.Address}'," +
                    $"`Phone`='{worker.Phone}'," +
                    $"`Email`='{worker.Email}'," +
                    $"`PESEL`='{worker.PESEL}'" +
                    $" WHERE ID LIKE {workerID}";

                MySqlCommand command = new MySqlCommand(UPDATE_WORKER, connection);
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

        // Usunięcie pracownika z BD
        public static bool DelWorker(Worker worker)
        {
            bool status = false;

            using (var connection = DBConnection.Instance.Connection)
            {
                string DEL_WORKER = $"DELETE FROM `workers` WHERE id LIKE {worker.ID}";

                MySqlCommand command = new MySqlCommand(DEL_WORKER, connection);
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
