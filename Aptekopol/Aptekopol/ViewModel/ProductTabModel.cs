using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aptekopol.ViewModel
{
    using Model;
    using DAL.Entities;
    using BaseClass;
    using System.Windows.Input;

    internal class ProductsTabModel : ViewModelBase
    {
        #region Attributes 
        private Model model = null;

        // Obsługa list
        private ObservableCollection<Product> products = null;
        private ObservableCollection<ProductSupplier> productsSuppliers = null;
        private int selectedProductIndex = -1;

        // Obsługa szczegółów produktów
        private int id;
        private double? price;
        private string name, description, remarks, category;

        // Obsługa przycisków szczegółów sklepu
        private bool addStatus = true, editStatus = false, delStatus = false;
        #endregion

        #region Constructor
        public ProductsTabModel(Model model)
        {
            this.model = model;
            this.products = model.ProductsCollection;
            this.productsSuppliers = model.ProductsSuppliersCollection;
        }
        #endregion

        #region Methods
        public Product CurrentProduct { get; set; }

        public ObservableCollection<ProductSupplier> CurrentProductSupplier { get; set; }

        public ObservableCollection<ProductSupplier> ProductsSuppliers
        {
            get { return this.productsSuppliers; }
            set
            {
                this.productsSuppliers = value;

                onPropertyChanged(nameof(ProductsSuppliers));
            }
        }

        public ObservableCollection<Product> Products
        {
            get { return this.products; }
            set
            {
                this.products = value;

                onPropertyChanged(nameof(Products));
            }
        }

        public int SelectedProductIndex
        {
            get => selectedProductIndex;
            set
            {
                selectedProductIndex = value;
                onPropertyChanged(nameof(SelectedProductIndex));
            }
        }

        public bool AddStatus
        {
            get { return addStatus; }
            set
            {
                addStatus = value;
                onPropertyChanged(nameof(AddStatus));
            }
        }

        public bool EditStatus
        {
            get { return editStatus; }
            set
            {
                editStatus = value;
                onPropertyChanged(nameof(EditStatus));
            }
        }

        public bool DelStatus
        {
            get { return delStatus; }
            set
            {
                delStatus = value;
                onPropertyChanged(nameof(DelStatus));
            }
        }

        private void ClearForm()
        {
            Name_product = "";
            Description_product = "";
            Price_product = null;
            Remarks_product = "";
            Category_product = "";

            selectedProductIndex = -1;
            AddStatus = true;
            EditStatus = false;
            DelStatus = false;
        }
        #endregion

        #region Properties
        public int ID_product
        {
            get { return id; }
            set
            {
                id = value;
                onPropertyChanged(nameof(ID_product));
            }
        }

        public string Name_product
        {
            get { return name; }
            set
            {
                name = value;
                onPropertyChanged(nameof(Name_product));
            }
        }

        public string Description_product
        {
            get { return description; }
            set
            {
                description = value;
                onPropertyChanged(nameof(Description_product));
            }
        }

        public double? Price_product
        {
            get { return price; }
            set
            {
                price = value;
                onPropertyChanged(nameof(Price_product));
            }
        }

        public string Remarks_product
        {
            get { return remarks; }
            set
            {
                remarks = value;
                onPropertyChanged(nameof(Remarks_product));
            }
        }

        public string Category_product
        {
            get { return category; }
            set
            {
                category = value;
                onPropertyChanged(nameof(Category_product));
            }
        }
        #endregion

        #region Commands
        // Załadowywanie
        private ICommand loadAllProducts = null;
        public ICommand LoadAllProducts
        {
            get
            {
                if (loadAllProducts == null)
                    loadAllProducts = new RelayCommand(
                        arg =>
                        {
                            Products = model.ProductsCollection;
                            selectedProductIndex = -1;
                        },
                        arg => true
                        );

                return loadAllProducts;
            }
        }

        // Obsługa czyszczenia formularza
        private ICommand clear = null;
        public ICommand Clear
        {
            get
            {
                if (clear == null)
                    clear = new RelayCommand(
                        arg =>
                        {
                            ClearForm();
                        },
                        arg => true
                        );

                return clear;
            }
        }

        // Obsługa formularza
        private ICommand loadForm = null;
        public ICommand LoadForm
        {
            get
            {
                if (loadForm == null)
                    loadForm = new RelayCommand(
                        arg =>
                        {
                            if (SelectedProductIndex > -1)
                            {
                                Name_product = CurrentProduct.Name;
                                Description_product = CurrentProduct.Description;
                                Price_product = CurrentProduct.Price;
                                Remarks_product = CurrentProduct.Remarks;
                                Category_product = CurrentProduct.Category;



                                AddStatus = false;
                                EditStatus = true;
                                DelStatus = true;
                            }
                            else
                            {
                                Name_product = "";
                                Description_product = "";
                                Price_product = null;
                                Remarks_product = "";
                                Category_product = "";

                                selectedProductIndex = -1;
                                AddStatus = true;
                                EditStatus = false;
                                DelStatus = false;
                            }
                        },
                        arg => true
                    );

                return loadForm;
            }

        }

        // Obsługa polecenia dodawania
        private ICommand add = null;
        public ICommand Add
        {
            get
            {
                if (add == null)
                    add = new RelayCommand(
                        arg =>
                        {
                            var shop = new Product(Name_product, Description_product, Price_product, Remarks_product, Category_product);

                            if (model.AddProduct(shop))
                            {
                                ClearForm();
                                System.Windows.MessageBox.Show("Pomyślnie dodano nowy produkt do Bazy Danych!");
                            }
                        },
                        arg =>
                            Name_product != "" &&
                            Description_product != "" &&
                            Price_product != null &&
                            Remarks_product != "" &&
                            Category_product != ""
                    );

                return add;
            }

        }

        // Obsługa polecenia edycji
        private ICommand edit = null;
        public ICommand Edit
        {
            get
            {
                if (edit == null)
                    edit = new RelayCommand(
                        arg =>
                        {
                            if (model.EditProduct(new Product(Name_product, Description_product, Price_product, Remarks_product, Category_product), (int)CurrentProduct.ID))
                            {
                                ClearForm();
                                System.Windows.MessageBox.Show("Pomyślnie edytowano produkt w Bazie Danych!");
                            }
                        },
                        arg =>
                            Name_product != "" &&
                            Description_product != "" &&
                            Price_product != null &&
                            Remarks_product != "" &&
                            Category_product != ""
                   );
                return edit;
            }
        }

        // Obsługa polecenia usuwania
        private ICommand del = null;
        public ICommand Del
        {

            get
            {
                if (del == null)
                    del = new RelayCommand(
                        arg =>
                        {
                            if (model.DelProduct(CurrentProduct))
                            {
                                ClearForm();
                                System.Windows.MessageBox.Show("Pomyślnie usunięto produkt z Bazy Danych!");
                            }
                        },
                        arg =>
                            Name_product != "" &&
                            Description_product != "" &&
                            Price_product != null &&
                            Remarks_product != "" &&
                            Category_product != ""
                    );

                return del;
            }
        }
        #endregion
    }
}
