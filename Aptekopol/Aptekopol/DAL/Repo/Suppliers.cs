using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Aptekopol.DAL.Repo
{
    using Entities;
    internal class Suppliers
    {
        #region Queries
        private const string GET_ALL_SUPPLIERS = "SELECT * FROM `suppliers`";
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
                string UPDATE = $" WHERE ID LIKE {id}";

                MySqlCommand command = new MySqlCommand($"{GET_ALL_SUPPLIERS} {UPDATE}", connection);
                connection.Open();

                var reader = command.ExecuteReader();
                supplier = new Supplier(reader);

                connection.Close();
            }
            return supplier;
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

        // Edycja istniejącego dostawcy
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
                    $"`Email`='{supplier.Email}'," +
                    $"`NIP`='{supplier.NIP}'" +
                    $"`Remarks`='{supplier.Remarks}'," +
                    $" WHERE ID LIKE {supplierID}";

                MySqlCommand command = new MySqlCommand(UPDATE_SUPPLIER, connection);
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

        // Usunięcie dostawcy z BD
        public static bool DelSupplier(Supplier supplier)
        {
            bool status = false;

            using (var connection = DBConnection.Instance.Connection)
            {
                string DEL_SUPPLIER = $"DELETE FROM `suppliers` WHERE id LIKE {supplier.ID}";

                MySqlCommand command = new MySqlCommand(DEL_SUPPLIER, connection);
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
