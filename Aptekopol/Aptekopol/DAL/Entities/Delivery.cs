using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Aptekopol.DAL.Entities
{
    using DAL.Repo;
    internal class Delivery
    {

        #region Properties
        public sbyte? ID { get; set; }

        public int Product_ID { get; set; }

        public int Supplier_ID { get; set; }

        public string Price { get; set; }

        public string Amount { get; set; }
        #endregion

        #region Constructors
        // Stowrzenie obiektu na podstawie otrzymanych danych z BD
        public Delivery(MySqlDataReader reader)
        {
            ID = sbyte.Parse(reader["ID"].ToString());
            Product_ID = int.Parse(reader["Product_ID"].ToString());
            Supplier_ID = int.Parse(reader["Supplier_ID"].ToString());
            Price = reader["Price"].ToString();
            Amount = reader["Amount"].ToString();
        }

        // Stworzenie obiektu na podstawie podanych danych z ID NULL
        public Delivery(int product_ID, int supplier_ID, string price, string amount)
        {
            ID = null;
            Product_ID = product_ID;
            Supplier_ID = supplier_ID;
            Price = price;
            Amount = amount;
        }

        public Delivery(Delivery delivery)
        {
            ID = null;
            Product_ID = delivery.Product_ID;
            Supplier_ID = delivery.Supplier_ID;
            Price = delivery.Price;
            Amount = delivery.Amount; 
        }
        #endregion

        #region Methods
        // Metoda generująca string dla INSERT TO
        public string ToInsert()
        {
            return $"('{Product_ID}', '{Supplier_ID}', '{Price}', '{Amount}')";
        }

        // Przeciążenie metody Equals
        public override bool Equals(object obj)
        {
            var delivery = obj as Delivery;
            if (delivery is null) return false;
            if (Product_ID != delivery.Product_ID) return false;
            if (Supplier_ID != delivery.Supplier_ID) return false;
            if (Price != delivery.Price) return false;
            if (Amount != delivery.Amount) return false;
   
            return true;
        }

        // Funkcja do zwracania hashu obiektu
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        // Funkcja do pobrania sklepu do którego przypisany jest kontrakt 
        public Product GetProductByID()
        {
            // dodać funkcję przy produktach
            Product product = null;//  = Products.GetProductByID(Product_ID);
            return product;
        }

        // Funkcja do pobrania pracownika do którego przypisany jest kontrakt
        public Supplier GetSupplierByDelivery()
        {
           Supplier supplier = Suppliers.GetSupplierByID(Supplier_ID);
            return supplier;
        }
        #endregion
    }
}
