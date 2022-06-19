using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Aptekopol.DAL.Entities
{
    using DAL.Repo;
    internal class Order
    {
        #region Properties
        public sbyte? Order_ID { get; set; }

        public int Client_ID { get; set; }

        public int Shop_ID { get; set; }

        public int Worker_ID { get; set; }

        public int Product_ID { get; set; }

        public int Quantity { get; set; }

        public DateTime Order_date { get; set; }
        #endregion

        #region Constructors
        // Stowrzenie obiektu na podstawie otrzymanych danych z BD
        public Order(MySqlDataReader reader)
        {
            Order_ID = sbyte.Parse(reader["Order_ID"].ToString());
            Client_ID = int.Parse(reader["Client_ID"].ToString());
            Shop_ID = int.Parse(reader["Shop_ID"].ToString());
            Worker_ID = int.Parse(reader["Worker_ID"].ToString());
            Product_ID = int.Parse(reader["Product_ID"].ToString());
            Quantity = int.Parse(reader["Quantity"].ToString());
            Order_date = DateTime.Parse(reader["Order_date"].ToString());
        }

        // Stworzenie obiektu na podstawie podanych danych z ID NULL
        public Order(int orderID, int clientID, int shopID, int workerID, int productID, int quantity, DateTime orderdate)
        {
            Order_ID = null;
            Client_ID = clientID;
            Shop_ID = shopID;
            Worker_ID = workerID;
            Product_ID = productID;
            Quantity = quantity;
            Order_date = orderdate;
        }

        public Order(Order order)
        {
            Order_ID = order.Order_ID;
            Client_ID = order.Client_ID;
            Shop_ID = order.Shop_ID;
            Worker_ID = order.Worker_ID;
            Product_ID = order.Product_ID;
            Quantity = order.Quantity;
            Order_date = order.Order_date;
        }
        #endregion

        #region Methods
        // Metoda generująca string dla INSERT TO
        public string ToInsert()
        {
            return $"('{Order_ID}', '{Client_ID}', '{Shop_ID}', '{Worker_ID}', '{Product_ID}', '{Quantity}', '{Order_date}')";
        }

        // Przeciążenie metody Equals
        public override bool Equals(object obj)
        {
            var order = obj as Order;
            if (order is null) return false;
            if (Order_ID != order.Order_ID) return false;
            if (Client_ID != order.Client_ID) return false;
            if (Shop_ID != order.Shop_ID) return false;
            if (Worker_ID != order.Worker_ID) return false;
            if (Product_ID != order.Product_ID) return false;
            if (Quantity != order.Quantity) return false;
            if (!Order_date.Equals(order.Order_date)) return false;

            return true;
        }

        // Funkcja do zwracania hashu obiektu
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        internal static bool AddOrder(Order order)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
