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
    internal class OrdersTabModel : ViewModelBase
    {
        
        /*#region Attributes 
        private Model model = null;

        // Obsługa listy
        private ObservableCollection<Order> orders = null;
        // Orders względem klienta, sklepu, pracownika i productID ja nie ponimaju
        // private ObservableCollection<OrderView> ordersView = null;
        // private ObservableCollection<OrderView> currentOrdersView = null;
        private int selectedOrderIndex = -1;

        // Obsługa szczegółów
        private int orderid, clientid, shopid, workerid, productid, quantity;
        private DateTime order_date;
        private DateTime dataNow = DateTime.Now;

        // Obsługa przycisków szczegółów
        private bool addStatus = true, editStatus = false, delStatus = false;
        #endregion

        #region Constructor
        public OrdersTabModel(Model model)
        {
            this.model = model;
            this.orders = model.OrderCollection;
        }
        #endregion

        #region Methods
        public Order CurrentOrder { get; set; }

        public ObservableCollection<Order> Orders
        {
            get { return this.orders; }
            set
            {
                this.orders = value;

                onPropertyChanged(nameof(Orders));
            }
        }

        public int SelectedOrderIndex
        {
            get => selectedOrderIndex;
            set
            {
                selectedOrderIndex = value;
                onPropertyChanged(nameof(SelectedOrderIndex));
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
            orderid = int.Parse(null);
            clientid = int.Parse(null);
            shopid = int.Parse(null);
            workerid = int.Parse(null);
            productid = int.Parse(null);
            quantity = int.Parse(null);
            order_date = dataNow;

            selectedOrderIndex = -1;

            AddStatus = true;
            EditStatus = false;
            DelStatus = false;
        }
        #endregion

        #region Properties
        public int ID_order
        {
            get { return orderid; }
            set
            {
                orderid = value;
                onPropertyChanged(nameof(ID_order));
            }
        }

        public int ID_client
        {
            get { return clientid; }
            set
            {
                clientid = value;
                onPropertyChanged(nameof(ID_client));
            }
        }

        public int ID_shop
        {
            get { return shopid; }
            set
            {
                shopid = value;
                onPropertyChanged(nameof(ID_shop));
            }
        }

        public int ID_worker
        {
            get { return workerid; }
            set
            {
                workerid = value;
                onPropertyChanged(nameof(ID_worker));
            }
        }

        public int ID_product
        {
            get { return productid; }
            set
            {
                productid = value;
                onPropertyChanged(nameof(ID_product));
            }
        }

        public int Quantity
        {
            get { return quantity; }
            set
            {
                quantity = value;
                onPropertyChanged(nameof(Quantity));
            }
        }

        public DateTime Order_date
        {
            get { return order_date; }
            set
            {
                order_date = value;
                onPropertyChanged(nameof(Order_date));
            }
        }
        #endregion

        #region Commands
        // Załadowywanie zamówień
        private ICommand loadAllOrders = null;
        public ICommand LoadAllOrders
        {
            get
            {
                if (loadAllOrders == null)
                    loadAllOrders = new RelayCommand(
                        arg =>
                        {
                            Orders = model.OrderCollection;
                            selectedOrderIndex = -1;
                        },
                        arg => true
                        );

                return loadAllOrders;
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
                            if (SelectedOrderIndex > -1)
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
                            }
                            else
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
        #endregion*/
    }
}
