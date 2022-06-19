using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Aptekopol.DAL.Entities
{
    internal class ProductSupplier
    {
        #region Properties
        public int DeliveryID { get; set; }
        public string ProductName { get; set; }
        public string SupplierName { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }
        #endregion

        #region Constructors
        // Stowrzenie obiektu na podstawie otrzymanych danych z BD
        public ProductSupplier(MySqlDataReader reader)
        {
            DeliveryID = int.Parse(reader["deliveryID"].ToString());
            ProductName = reader["productName"].ToString();
            SupplierName = reader["supplierName"].ToString();
            Price = double.Parse(reader["price"].ToString());
            Amount = int.Parse(reader["amount"].ToString());
        }
        #endregion
    }
}
