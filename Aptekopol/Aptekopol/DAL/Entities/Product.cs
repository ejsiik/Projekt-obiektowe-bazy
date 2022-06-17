using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Aptekopol.DAL.Entities
{
    internal class Product
    {
        #region Properties
        public sbyte? ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public float Price { get; set; }

        public string Remarks { get; set; }

        public string Category { get; set; }
        #endregion

        #region Constructors
        // Stowrzenie obiektu na podstawie otrzymanych danyc z BD
        public Product(MySqlDataReader reader)
        {
            ID = sbyte.Parse(reader["ID"].ToString());
            Name = reader["Name"].ToString();
            Description = reader["Description"].ToString();
            Price = float.Parse(reader["Price"].ToString());
            Remarks = reader["Remarks"].ToString();
            Category = reader["Category"].ToString();
        }

        // Stworzenie obiektu na podstawie podanych danych z ID NULL
        public Product(string name, string description, float price, string remarks, string category)
        {
            ID = null;
            Name = name;
            Description = description;
            Price = price;
            Remarks = remarks;
            Category = category;
        }

        public Product(Product Product)
        {
            ID = Product.ID;
            Name = Product.Name;
            Description = Product.Description;
            Price = Product.Price;
            Remarks = Product.Remarks;
            Category = Product.Category;
        }
        #endregion

        #region Methods
        // Metoda generująca string dla INSERT TO
        public string ToInsert()
        {
            return $"('{Name}', '{Description}', '{Price}', '{Remarks}', '{Category}')";
        }

        // Przeciążenie metody Equals
        public override bool Equals(object obj)
        {
            var product = obj as Product;
            if (product is null) return false;
            if (Name.ToLower() != product.Name.ToLower()) return false;
            if (Description.ToLower() != product.Description.ToLower()) return false;
            if (Price != product.Price) return false;
            if (Remarks.ToLower() != product.Remarks.ToLower()) return false;
            if (Category.ToLower() != product.Category.ToLower()) return false;

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
