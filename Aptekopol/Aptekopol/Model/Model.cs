using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aptekopol.Model
{
    using DAL.Entities;
    using DAL.Repo;
    using System.Collections.ObjectModel;

    class Model
    {
        #region DB State
        public ObservableCollection<Worker> WorkersCollection { get; set; } = new ObservableCollection<Worker>();
        public ObservableCollection<Shop> ShopsCollection { get; set; } = new ObservableCollection<Shop>();
        public ObservableCollection<Product> ProductsCollection { get; set; } = new ObservableCollection<Product>();
        #endregion

        #region Constructors
        //Pobranie danych z BD do kolekcji
        public Model()
        {
            var workers = Workers.GetAllWorkers();
            var shops = Shops.GetAllShops();
            var products = Products.GetAllProducts();

            foreach (var w in workers)
                WorkersCollection.Add(w);

            foreach (var s in shops)
                ShopsCollection.Add(s);

            foreach (var p in products)
                ProductsCollection.Add(p);
        }
        #endregion

        #region Worker Methods
        public bool CheckIfWorkerExist(Worker worker) => WorkersCollection.Contains(worker);

        public bool AddWorker(Worker worker)
        {
            if (!CheckIfWorkerExist(worker))
            {
                if (Workers.AddWorker(worker))
                {
                    WorkersCollection.Add(worker);
                    return true;
                }
            }
            return false;
        }

        public bool EditWorker(Worker worker, int id)
        {
            if (Workers.EditWorker(worker, id))
            {
                worker.ID = (sbyte?)id;
                WorkersCollection[id - 1] = new Worker(worker);
                return true;
            }
            return false;
        }

        public bool DelWorker(Worker worker)
        {
            if (Workers.DelWorker(worker))
            {
                WorkersCollection.Remove(worker);
                return true;
            }

            return false;
        }
        #endregion

        #region Shop Methods
        public bool CheckIfShopExist(Shop shop) => ShopsCollection.Contains(shop);

        public bool AddShop(Shop shop)
        {
            if (!CheckIfShopExist(shop))
            {
                if (Shops.AddShop(shop))
                {
                    ShopsCollection.Add(shop);
                    return true;
                }
            }
            return false;
        }

        public bool EditShop(Shop shop, int id)
        {
            if (Shops.EditShop(shop, id))
            {
                shop.ID = (sbyte?)id;
                ShopsCollection[id - 1] = new Shop(shop);
                return true;
            }
            return false;
        }

        public bool DelShop(Shop shop)
        {
            if (Shops.DelShop(shop))
            {
                ShopsCollection.Remove(shop);
                return true;
            }

            return false;
        }
        #endregion

        #region Product Methods
        public bool CheckIfProductExist(Product product) => ProductsCollection.Contains(product);

        public bool AddProduct(Product product)
        {
            if (!CheckIfProductExist(product))
            {
                if (Products.AddProduct(product))
                {
                    ProductsCollection.Add(product);
                    return true;
                }
            }
            return false;
        }

        public bool EditProduct(Product product, int id)
        {
            if (Products.EditProduct(product, id))
            {
                product.ID = (sbyte?)id;
                ProductsCollection[id - 1] = new Product(product);
                return true;
            }
            return false;
        }

        public bool DelProduct(Product product)
        {
            if (Products.DelProduct(product))
            {
                ProductsCollection.Remove(product);
                return true;
            }

            return false;
        }
        #endregion
    }
}
