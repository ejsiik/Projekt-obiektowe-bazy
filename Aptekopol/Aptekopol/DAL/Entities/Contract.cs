using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Aptekopol.DAL.Entities
{
    using DAL.Repo;

    internal class Contract
    {
        #region Properties
        public sbyte? ID { get; set; }

        public int Worker_ID { get; set; }

        public int Shop_ID { get; set; }

        public string Contract_number { get; set; }

        public string Signing_date { get; set; }

        public string Expiration_date { get; set; }

        public int Salary { get; set; }

        public string Job_title { get; set; }
        #endregion

        #region Constructors
        // Stowrzenie obiektu na podstawie otrzymanych danych z BD
        public Contract(MySqlDataReader reader)
        {
            ID = sbyte.Parse(reader["ID"].ToString());
            Worker_ID = int.Parse(reader["Workers_ID"].ToString());
            Shop_ID = int.Parse(reader["Shop_ID"].ToString());
            Contract_number = reader["Contract_number"].ToString();
            Signing_date = reader["Signing_date"].ToString();
            Expiration_date = reader["Expiration_date"].ToString();
            Salary = int.Parse(reader["Salary"].ToString());
            Job_title = reader["Job_title"].ToString();
        }

        // Stworzenie obiektu na podstawie podanych danych z ID NULL
        public Contract(int worker_ID, int shop_ID, string contract_number, string signing_date, string expiration_date, int salary, string job_title)
        {
            ID = null;
            Worker_ID = worker_ID; 
            Shop_ID = shop_ID;
            Contract_number = contract_number;
            Signing_date = signing_date;
            Expiration_date = expiration_date;
            Salary = salary;
            Job_title = job_title;
        }

        public Contract(Contract contract)
        {
            ID = null;
            Worker_ID = contract.Worker_ID;
            Shop_ID = contract.Shop_ID;
            Contract_number = contract.Contract_number;
            Signing_date = contract.Signing_date;
            Expiration_date = contract.Expiration_date;
            Salary = contract.Salary;
            Job_title = contract.Job_title;
        }
        #endregion

        #region Methods
        // Metoda generująca string dla INSERT TO
        public string ToInsert()
        {
            return $"('{Worker_ID}', '{Shop_ID}', '{Contract_number}', '{Signing_date}', '{Expiration_date}', '{Salary}', '{Job_title}')";
        }

        // Przeciążenie metody Equals
        public override bool Equals(object obj)
        {
            var contract = obj as Contract;
            if (contract is null) return false;
            if (Worker_ID != contract.Worker_ID) return false;
            if (Shop_ID != contract.Shop_ID) return false;
            if (Contract_number.ToLower() != contract.Contract_number.ToLower()) return false;
            if (Signing_date.ToLower() != contract.Signing_date.ToLower()) return false;
            if (Expiration_date.ToLower() != contract.Expiration_date.ToLower()) return false;
            if (Salary != contract.Salary) return false;
            if (Expiration_date.ToLower() != contract.Expiration_date.ToLower()) return false;

            return true;
        }

        // Funkcja do zwracania hashu obiektu
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        // Funkcja do pobrania sklepu do którego przypisany jest kontrakt 
        public Shop GetShopByContract()
        {
            Shop shop = Shops.GetShopByID(Shop_ID);
            return shop;
        }

        // Funkcja do pobrania pracownika do którego przypisany jest kontrakt
        public Worker GetWorkerByContract()
        {
            Worker worker = Workers.GetWorkerByID(Worker_ID);
            return worker;
        }
        #endregion
    }
}
