using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Aptekopol.DAL.Entities
{
    internal class Worker
    {
        #region Properties
        public sbyte? ID { get; set; }

        public string Firstname { get; set; }  

        public string Surname { get; set; }

        public string City { get; set; }

        public string Address { get; set; } 

        public string Phone { get; set; }

        public string Email { get; set; }

        public string PESEL { get; set; }
        #endregion

        #region Constructors
        // Stowrzenie obiektu na podstawie otrzymanych danyc z BD
        public Worker(MySqlDataReader reader)
        {
            ID = sbyte.Parse(reader["ID"].ToString());
            Firstname = reader["Firstname"].ToString();
            Surname = reader["Surname"].ToString();
            City = reader["City"].ToString();
            Address = reader["Address"].ToString();
            Phone = reader["Phone"].ToString();
            Email = reader["Email"].ToString();
            PESEL = reader["PESEL"].ToString();
        }

        // Stworzenie obiektu na podstawie podanych danych z ID NULL
        public Worker(string firstname, string surname, string city, string address, string phone, string email, string pesel)
        {
            ID = null;
            Firstname = firstname.Trim();
            Surname = surname.Trim();
            City = city.Trim();
            Address = address.Trim();
            Phone = phone.Trim();
            Email = email.Trim();
            PESEL = pesel.Trim();
        }

        public Worker(Worker worker)
        {
            ID = worker.ID;
            Firstname = worker.Firstname;
            Surname = worker.Surname;   
            City = worker.City; 
            Address = worker.Address;
            Phone = worker.Phone;
            Email = worker.Email;
            PESEL = worker.PESEL;
        }
        #endregion

        #region Methods
        // Metoda generująca string dla INSERT TO
        public string ToInsert()
        {
            return $"('{Firstname}', '{Surname}', '{City}', '{Address}', '{Phone}', '{Email}', '{PESEL}')"; 
        }

        // Przeciążenie metody Equals, do sprawdzania czy dana osoba jest już na liscie
        public override bool Equals(object obj)
        {
            var worker = obj as Worker;
            if (worker is null) return false;
            if (Firstname.ToLower() != worker.Firstname.ToLower()) return false;
            if (Surname.ToLower() != worker.Surname.ToLower()) return false;
            if (City.ToLower() != worker.City.ToLower()) return false;
            if (Address.ToLower() != worker.Address.ToLower()) return false;
            if (Phone.ToLower() != worker.Phone.ToLower()) return false;
            if (Email.ToLower() != worker.Email.ToLower()) return false;
            if (PESEL.ToLower() != worker.PESEL.ToLower()) return false;

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
