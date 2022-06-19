using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Aptekopol.DAL.Entities
{
    internal class OrderView
    {
        #region Properties
        public int OrderID { get; set; }
        public string ClientLogin { get; set; }
        public string OrderDate { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double TotalPrice { get; set; }
        public string Shop { get; set; }
        public string AssignedTo { get; set; }
        #endregion

        #region Constructors
        // Stowrzenie obiektu na podstawie otrzymanych danych z BD
        public OrderView(MySqlDataReader reader)
        {
            OrderID = int.Parse(reader["orderID"].ToString());
            ClientLogin = reader["clientLogin"].ToString();
            OrderDate = reader["orderDate"].ToString();
            ProductName = reader["productName"].ToString();
            Quantity = int.Parse(reader["quantity"].ToString());
            UnitPrice = double.Parse(reader["unitPrice"].ToString());
            TotalPrice = double.Parse(reader["totalPrice"].ToString());
            Shop = reader["shop"].ToString();
            AssignedTo = reader["assignedTo"].ToString();
        }
        #endregion
    }
}
