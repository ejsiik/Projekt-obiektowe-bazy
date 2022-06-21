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

    internal class ShopsTabModel : ViewModelBase
    {
        #region Attributes 
        private Model model = null;

        // Obsługa listy sklepów
        private ObservableCollection<Shop> shops = null;
        private int selectedShopIndex = -1;

        // Obsługa szczegółów sklepu
        private int id;
        private string city, address, phone, email;

        // Obsługa przycisków szczegółów sklepu
        private bool addStatus = true, editStatus = false, delStatus = false;
        #endregion

        #region Constructor
        public ShopsTabModel(Model model) 
        {
            this.model = model;
            this.shops = model.ShopsCollection;
        }
        #endregion

        #region Methods
        public Shop CurrentShop { get; set; }

        public ObservableCollection<Shop> Shops
        {
            get { return this.shops; }
            set
            {
                this.shops = value;
                
                onPropertyChanged(nameof(Shops));
            }
        }

        public int SelectedShopIndex
        {
            get => selectedShopIndex;
            set
            {
                selectedShopIndex = value;
                onPropertyChanged(nameof(SelectedShopIndex));
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
            City_shop = "";
            Address_shop = "";
            Phone_shop = "";
            Email_shop = "";
            selectedShopIndex = -1;

            AddStatus = true;
            EditStatus = false;
            DelStatus = false;
        }
        #endregion

        #region Properties
        public int ID_shop
        {
            get { return id; }
            set
            {
                id = value;
                onPropertyChanged(nameof(ID_shop));
            }
        }

        public string City_shop
        {
            get { return city; }
            set
            {
                city = value;
                onPropertyChanged(nameof(City_shop));
            }
        }

        public string Address_shop
        {
            get { return address; }
            set
            {
                address = value;
                onPropertyChanged(nameof(Address_shop));
            }
        }

        public string Phone_shop
        {
            get { return phone; }
            set
            {
                phone = value;
                onPropertyChanged(nameof(Phone_shop));
            }
        }

        public string Email_shop
        {
            get { return email; }
            set
            {
                email = value;
                onPropertyChanged(nameof(Email_shop));
            }
        }
        #endregion

        #region Commands
        // Załadowywanie pracowników
        private ICommand loadAllShops = null;
        public ICommand LoadAllShops
        {
            get
            {
                if (loadAllShops == null)
                    loadAllShops = new RelayCommand(
                        arg =>
                        {
                            Shops = model.ShopsCollection;
                            selectedShopIndex = -1;
                        },
                        arg => true
                        );

                return loadAllShops;
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
                            if (SelectedShopIndex > -1)
                            {
                                City_shop = CurrentShop.City;
                                Address_shop = CurrentShop.Address;
                                Phone_shop = CurrentShop.Phone;
                                Email_shop = CurrentShop.Email;
                                AddStatus = false;
                                EditStatus = true;
                                DelStatus = true;
                            }
                            else
                            {
                                City_shop = "";
                                Address_shop = "";
                                Phone_shop = "";
                                Email_shop = "";
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
                            if (City_shop == null || Address_shop == null || Phone_shop == null || Email_shop == null)
                            {
                                System.Windows.MessageBox.Show("Proszę wypełnić wszystskie Pola!");
                                return;
                            }

                            var shop = new Shop(City_shop, Address_shop, Phone_shop, Email_shop);

                            if (model.AddShop(shop))
                            {
                                ClearForm();
                                System.Windows.MessageBox.Show("Pomyślnie dodano nowy sklep do Bazy Danych!");
                            }
                        },
                        arg =>
                            City_shop != "" &&
                            Address_shop != "" &&
                            Phone_shop != "" &&
                            Email_shop != ""
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
                            if (model.EditShop(new Shop(City_shop, Address_shop, Phone_shop, Email_shop), (int)CurrentShop.ID))
                            {
                                ClearForm();
                                System.Windows.MessageBox.Show("Pomyślnie edytowano sklep w Bazie Danych!");
                            }
                            else
                            {
                                ClearForm();
                                System.Windows.MessageBox.Show("Nie udało się edytować z Bazy Danych, ponieważ ma istniejące dowiązania.");
                            }
                        },
                        arg =>
                            City_shop != "" &&
                            Address_shop != "" &&
                            Phone_shop != "" &
                            Email_shop != "" 
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
                            if (model.DelShop(CurrentShop))
                            {
                                ClearForm();
                                System.Windows.MessageBox.Show("Pomyślnie usunięto skelp z Bazy Danych!");
                            } else
                            {
                                ClearForm();
                                System.Windows.MessageBox.Show("Nie udało się usunąć sklepu z Bazy Danych, ponieważ ma powiązanych pacowników i zamówienia.");
                            }
                        },
                        arg =>
                            City_shop != "" &&
                            Address_shop != "" &&
                            Phone_shop != "" &&
                            Email_shop != ""
                    );

                return del;
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
        #endregion
    }
}
