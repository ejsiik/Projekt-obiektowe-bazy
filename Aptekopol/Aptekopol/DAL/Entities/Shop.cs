using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Aptekopol.DAL.Entities
{
    internal class Shop
    {
        #region Properties
        public sbyte? ID { get; set; }

        public string City { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }
        #endregion

        #region Constructors
        // Stowrzenie obiektu na podstawie otrzymanych danyc z BD
        public Shop(MySqlDataReader reader)
        {
            ID = sbyte.Parse(reader["ID"].ToString());
            City = reader["City"].ToString();
            Address = reader["Address"].ToString();
            Phone = reader["Phone"].ToString();
            Email = reader["Email"].ToString();
        }

        // Stworzenie obiektu na podstawie podanych danych z ID NULL
        public Shop(string city, string address, string phone, string email)
        {
            try 
            {
            ID = null;
            City = city.Trim();
            Address = address.Trim();
            Phone = phone.Trim();
            Email = email.Trim(); 
            }
            catch { System.Windows.MessageBox.Show("Błąd"); }
        }

        public Shop(Shop shop)
        {
            ID = shop.ID;
            City = shop.City;
            Address = shop.Address;
            Phone = shop.Phone;
            Email = shop.Email;
        }
        #endregion

        #region Methods
        // Metoda generująca string dla INSERT TO
        public string ToInsert()
        {
            return $"('{City}', '{Address}', '{Phone}', '{Email}')";
        }

        // Przeciążenie metody Equals, do sprawdzania czy dany sklep jest już na liscie
        public override bool Equals(object obj)
        {
            var worker = obj as Worker;
            if (worker is null) return false;
            if (City.ToLower() != worker.City.ToLower()) return false;
            if (Address.ToLower() != worker.Address.ToLower()) return false;
            if (Phone.ToLower() != worker.Phone.ToLower()) return false;
            if (Email.ToLower() != worker.Email.ToLower()) return false;

            return true;
        }

        // Funkcja do zwracania hashu obiektu
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion
    }
}
