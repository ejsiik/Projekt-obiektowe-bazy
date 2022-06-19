using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Aptekopol.DAL.Repo
{
    using Entities;
    internal class Deliveries
    {
        #region Queries
        private const string GET_ALL_SUPPLIERS = "SELECT * FROM `suppliers`";
        private const string GET_ALL_DELIVERIES = "SELECT * FROM `delivery` WHERE `Supplier_ID` LIKE ";
        private const string INSERT_INTO_SUPPLIERS = "INSERT INTO `suppliers`(`Name`, `City`, `Address`, `Phone`, `Email`, `NIP`, `Remarks`) VALUES ";
        #endregion

        #region CRUD
        // Pobranie wszystkich dostawców z DB i stworzenie z nich listy
        public static List<Supplier> GetAllSuppliers()
        {
            List<Supplier> suppliers = new List<Supplier>();
            using (var connection = DBConnection.Instance.Connection)
            {
                MySqlCommand command = new MySqlCommand(GET_ALL_SUPPLIERS, connection);
                connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                    suppliers.Add(new Supplier(reader));

                connection.Close();
            }
            return suppliers;
        }

        public static Supplier GetSupplierByID(int id)
        {
            Supplier supplier = null;
            using (var connection = DBConnection.Instance.Connection)
            {
                string UPDATE_SUPPLIER = $" WHERE ID LIKE {id}";

                MySqlCommand command = new MySqlCommand($"{GET_ALL_SUPPLIERS} {UPDATE_SUPPLIER}", connection);
                connection.Open();

                var reader = command.ExecuteReader();
                supplier = new Supplier(reader);

                connection.Close();
            }
            return supplier;
        }

        public static List<Delivery> GetAllDeliveriesBySupplier(Supplier supplier)
        {
            List<Delivery> deliveries = new List<Delivery>();
            using (var connection = DBConnection.Instance.Connection)
            {
                MySqlCommand command = new MySqlCommand($"{GET_ALL_DELIVERIES} {supplier.ID}", connection);
                connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                    deliveries.Add(new Delivery(reader));

                connection.Close();
            }
            return deliveries;
        }

        // Dodanie nowego dostawcy do BD
        public static bool AddSupplier(Supplier supplier)
        {
            bool status = false;

            using (var connection = DBConnection.Instance.Connection)
            {
                MySqlCommand command = new MySqlCommand($"{INSERT_INTO_SUPPLIERS} {supplier.ToInsert()}", connection);
                connection.Open();

                var id = command.ExecuteNonQuery();
                status = true;
                supplier.ID = (sbyte)command.LastInsertedId;
                connection.Close();
            }

            return status;
        }

        // Edycja istniejącego
        public static bool EditSupplier(Supplier supplier, int supplierID)
        {
            bool status = false;

            using (var connection = DBConnection.Instance.Connection)
            {
                string UPDATE_SUPPLIER = $"UPDATE `suppliers` SET " +
                    $"`Name`='{supplier.Name}'," +
                    $"`City`='{supplier.City}'," +
                    $"`Address`='{supplier.Address}'," +
                    $"`Phone`='{supplier.Phone}'," +
                    $"`Email`='{supplier.Email}'" +
                    $"`NIP`='{supplier.NIP}'" +
                    $"`Remarks`='{supplier.Remarks}'" +
                    $" WHERE ID LIKE {supplierID}";

                MySqlCommand command = new MySqlCommand(UPDATE_SUPPLIER, connection);
                connection.Open();

                var n = command.ExecuteNonQuery();
                if (n == 1) status = true;

                connection.Close();
            }

            return status;
        }

        // Usunięcie z BD
        public static bool DelSupplier(Supplier supplier)
        {
            bool status = false;

            using (var connection = DBConnection.Instance.Connection)
            {
                string DEL_SUPPLIER = $"DELETE FROM `suppliers` WHERE id LIKE {supplier.ID}";

                MySqlCommand command = new MySqlCommand(DEL_SUPPLIER, connection);
                connection.Open();

                var n = command.ExecuteNonQuery();
                if (n == 1) status = true;

                connection.Close();
            }

            return status;
        } //niepełne
        #endregion
    }
}
