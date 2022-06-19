using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Aptekopol.DAL.Entities
{
    using DAL.Repo;
    internal class Client
    {
        #region Properties
        public sbyte? ID { get; set; }

        public string Login { get; set; }

        public string Firstname { get; set; }

        public string Surname { get; set; }

        public bool IsCompany { get; set; }

        public string Name { get; set; }

        public string NIP { get; set; }

        public string City { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public DateTime PasswordLastChange { get; set; } //DATE?
        #endregion

        #region Constructors
        // Stowrzenie obiektu na podstawie otrzymanych danych z BD
        public Client(MySqlDataReader reader)
        {
            ID = sbyte.Parse(reader["ID"].ToString());
            Login = reader["Login"].ToString();
            Firstname = reader["Firstname"].ToString();
            Surname = reader["Surname"].ToString();
            IsCompany = bool.Parse(reader["Is_company"].ToString());
            Name = reader["Name"].ToString();
            NIP = reader["NIP"].ToString(); 
            City = reader["City"].ToString();
            Address = reader["Address"].ToString();
            Phone = reader["Phone"].ToString();
            Email = reader["Email"].ToString();
            Password = reader["Password"].ToString();
            PasswordLastChange = DateTime.Parse(reader["Password_last_change"].ToString());
        }

        // Stworzenie obiektu na podstawie podanych danych z ID NULL
        public Client(string login, string firstname, string surname, bool iscompany, string name, string nip, 
            string city, string address, string phone, string email, string password, DateTime passwordlastchange)
        {
            ID = null;
            Login = login.Trim();
            Firstname = firstname.Trim();
            Surname = surname.Trim();
            IsCompany = iscompany; //check czy na boolach działa bez niczego
            Name = name.Trim();
            NIP = nip.Trim();
            City = city.Trim();
            Address = address.Trim();
            Phone = phone.Trim();
            Email = email.Trim();
            Password = password.Trim();
            PasswordLastChange = passwordlastchange;
        }

        public Client(Client client)
        {
            ID = client.ID;
            Login = client.Login;
            Firstname = client.Firstname;
            Surname = client.Surname;
            IsCompany = client.IsCompany;
            Name = client.Name;
            NIP = client.NIP;
            City = client.City;
            Address = client.Address;
            Phone = client.Phone;
            Email = client.Email;
            Password = client.Password;
            PasswordLastChange = client.PasswordLastChange;
        }
        #endregion

        #region Methods
        // Metoda generująca string dla INSERT TO
        public string ToInsert()
        {
            return $"('{Login}', '{Firstname}', '{Surname}', '{IsCompany}', '{Name}', '{NIP}',  {City}'," +
                $" '{Address}', '{Phone}', '{Email}', '{Password}', '{PasswordLastChange}')";
        }

        // Przeciążenie metody Equals
        public override bool Equals(object obj)
        {
            var client = obj as Client;
            if (client is null) return false;
            if (Login.ToLower() != client.Login.ToLower()) return false;
            if (Firstname.ToLower() != client.Firstname.ToLower()) return false;
            if (Surname.ToLower() != client.Surname.ToLower()) return false;
            if (IsCompany != client.IsCompany) return false;
            if (Name.ToLower() != client.Name.ToLower()) return false;
            if (NIP.ToLower() != client.NIP.ToLower()) return false;
            if (City.ToLower() != client.City.ToLower()) return false;
            if (Address.ToLower() != client.Address.ToLower()) return false;
            if (Phone.ToLower() != client.Phone.ToLower()) return false;
            if (Email.ToLower() != client.Email.ToLower()) return false;
            if (Password.ToLower() != client.Password.ToLower()) return false;
            if (PasswordLastChange != client.PasswordLastChange) return false;

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
