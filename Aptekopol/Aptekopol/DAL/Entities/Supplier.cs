using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Aptekopol.DAL.Entities
{
    using DAL.Repo;
        internal class Supplier
    {
        #region Properties
        public sbyte? ID { get; set; }

        public string Name { get; set; }

        public string City { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string NIP { get; set; }

        public string Remarks { get; set; }
        #endregion

        #region Constructors
        // Stowrzenie obiektu na podstawie otrzymanych danych z BD
        public Supplier(MySqlDataReader reader)
        {
            ID = sbyte.Parse(reader["ID"].ToString());
            Name = reader["Name"].ToString();
            City = reader["City"].ToString();
            Address = reader["Address"].ToString();
            Phone = reader["Phone"].ToString();
            Email = reader["Email"].ToString();
            NIP = reader["NIP"].ToString();
            Remarks = reader["Remarks"].ToString();
        }

        // Stworzenie obiektu na podstawie podanych danych z ID NULL
        public Supplier(string name,  string city, string address, string phone, string email, string nip, string remarks)
        {
            ID = null;
            Name = name.Trim();
            City = city.Trim();
            Address = address.Trim();
            Phone = phone.Trim();
            Email = email.Trim();
            NIP = nip.Trim();
            Remarks = remarks.Trim();
        }

        public Supplier(Supplier supplier)
        {
            ID = supplier.ID;
            Name = supplier.Name;
            City = supplier.City;
            Address = supplier.Address;
            Phone = supplier.Phone;
            Email = supplier.Email;
            NIP = supplier.NIP;
            Remarks = supplier.Remarks;
        }
        #endregion

        #region Methods
        // Metoda generująca string dla INSERT TO
        public string ToInsert()
        {
            return $"('{Name}', '{City}', '{Address}', '{Phone}', '{Email}', '{NIP}', '{Remarks}')";
        }

        // Przeciążenie metody Equals
        public override bool Equals(object obj)
        {
            var supplier = obj as Supplier;
            if (supplier is null) return false;
            if (Name.ToLower() != supplier.Name.ToLower()) return false;
            if (City.ToLower() != supplier.City.ToLower()) return false;
            if (Address.ToLower() != supplier.Address.ToLower()) return false;
            if (Phone.ToLower() != supplier.Phone.ToLower()) return false;
            if (Email.ToLower() != supplier.Email.ToLower()) return false;
            if (NIP.ToLower() != supplier.NIP.ToLower()) return false;
            if (Remarks.ToLower() != supplier.Remarks.ToLower()) return false;

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
