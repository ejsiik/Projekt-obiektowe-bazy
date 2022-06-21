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

    internal class SuppliersTabModel : ViewModelBase
    {
        #region Attributes 
        private Model model = null;

        // Obsługa listy dostawców
        private ObservableCollection<Supplier> suppliers = null;
        private ObservableCollection<ProductSupplier> productsSuppliers = null;
        private ObservableCollection<ProductSupplier> currentSupplierProducts = null;
        private int selectedSupplierIndex = -1;

        // Obsługa szczegółów dostawcy
        private int id;
        private string name, city, address, phone, email, nip, remarks;

        // Obsługa przycisków szczegółów dostawcy
        private bool addStatus = true, editStatus = false, delStatus = false;
        #endregion

        #region Constructor
        public SuppliersTabModel(Model model)
        {
            this.model = model;
            this.suppliers = model.SuppliersCollection;
            this.productsSuppliers = model.ProductsSuppliersCollection;
        }
        #endregion

        #region Methods
        public Supplier CurrentSupplier { get; set; }

        public ObservableCollection<Supplier> Suppliers
        {
            get { return this.suppliers; }
            set
            {
                this.suppliers = value;

                onPropertyChanged(nameof(Suppliers));
            }
        }

        public ObservableCollection<ProductSupplier> CurrentSupplierProducts
        {
            get { return currentSupplierProducts; }
            set
            {
                this.currentSupplierProducts = value;

                onPropertyChanged(nameof(CurrentSupplierProducts));
            }
        }

        public int SelectedSupplierIndex
        {
            get => selectedSupplierIndex;
            set
            {
                selectedSupplierIndex = value;
                onPropertyChanged(nameof(SelectedSupplierIndex));
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
            Name = "";
            City = "";
            Address = "";
            Phone = "";
            Email = "";
            NIP = "";
            Remarks = "";
            SelectedSupplierIndex = -1;

            CurrentSupplierProducts = new ObservableCollection<ProductSupplier>();

            AddStatus = true;
            EditStatus = false;
            DelStatus = false;
        }
        #endregion

        #region Properties
        public int ID
        {
            get { return id; }
            set
            {
                id = value;
                onPropertyChanged(nameof(ID));
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                onPropertyChanged(nameof(Name));
            }
        }

        public string City
        {
            get { return city; }
            set
            {
                city = value;
                onPropertyChanged(nameof(City));
            }
        }

        public string Address
        {
            get { return address; }
            set
            {
                address = value;
                onPropertyChanged(nameof(Address));
            }
        }

        public string Phone
        {
            get { return phone; }
            set
            {
                phone = value;
                onPropertyChanged(nameof(Phone));
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                onPropertyChanged(nameof(Email));
            }
        }

        public string NIP
        {
            get { return nip; }
            set
            {
                nip = value;
                onPropertyChanged(nameof(NIP));
            }
        }

        public string Remarks
        {
            get { return remarks; }
            set
            {
                remarks = value;
                onPropertyChanged(nameof(Remarks));
            }
        }
        #endregion

        #region Commands
        // Załadowywanie dostawców
        private ICommand loadAllSuppliers = null;
        public ICommand LoadAllSuppliers
        {
            get
            {
                if (loadAllSuppliers == null)
                    loadAllSuppliers = new RelayCommand(
                        arg =>
                        {
                            Suppliers = model.SuppliersCollection;
                            selectedSupplierIndex = -1;
                        },
                        arg => true
                        );

                return loadAllSuppliers;
            }
        }

        // Wypelnianie formularza
        private ICommand loadForm = null;
        public ICommand LoadForm
        {

            get
            {
                if (loadForm == null)
                    loadForm = new RelayCommand(
                        arg =>
                        {
                            if (SelectedSupplierIndex > -1)
                            {
                                Name = CurrentSupplier.Name;
                                City = CurrentSupplier.City;
                                Address = CurrentSupplier.Address;
                                Phone = CurrentSupplier.Phone;
                                Email = CurrentSupplier.Email;
                                NIP = CurrentSupplier.NIP;
                                Remarks = CurrentSupplier.Remarks;

                                CurrentSupplierProducts = new ObservableCollection<ProductSupplier>();

                                for (int i = 0; i < productsSuppliers.Count; i++)
                                {
                                    if (name == productsSuppliers[i].SupplierName)
                                    {
                                        CurrentSupplierProducts.Add(productsSuppliers[i]);
                                    }
                                }

                                AddStatus = false;
                                EditStatus = true;
                                DelStatus = true;
                            }
                            else
                            {
                                Name = "";
                                City = "";
                                Address = "";
                                Phone = "";
                                Email = "";
                                NIP = "";
                                Remarks = "";

                                CurrentSupplierProducts = new ObservableCollection<ProductSupplier>();

                                AddStatus = true;
                                EditStatus = false;
                                DelStatus = false;
                            }
                        }
                        ,
                        arg => true
                        );

                return loadForm;
            }

        }

        // Obsługa polecenia dodawania dostawcy
        private ICommand add = null;
        public ICommand Add
        {
            get
            {
                if (add == null)
                    add = new RelayCommand(
                        arg =>
                        {
                            if (Name == null || City == null || Address == null || Phone == null || Email == null || NIP == null || Remarks == null)
                            {
                                System.Windows.MessageBox.Show("Proszę wypełnić wszystskie Pola!");
                                return;
                            }

                            var supplier = new Supplier(Name, City, Address, Phone, Email, NIP, Remarks);

                            if (model.AddSupplier(supplier))
                            {
                                ClearForm();
                                System.Windows.MessageBox.Show("Pomyślnie dodano nowego dostawcę do Bazy Danych!");
                            }
                        },
                        arg =>
                            Name != "" &&
                            City != "" &&
                            Address != "" &&
                            Phone != "" &&
                            Email != "" &&
                            NIP != "" &&
                            Remarks != ""
                    );

                return add;
            }

        }

        // Obsługa polecenia edycji dostawcy
        private ICommand edit = null;
        public ICommand Edit
        {
            get
            {
                if (edit == null)
                    edit = new RelayCommand(
                        arg =>
                        {
                            if (model.EditSupplier(new Supplier(Name, City, Address, Phone, Email, NIP, Remarks), (int)CurrentSupplier.ID))
                            {
                                ClearForm();
                                System.Windows.MessageBox.Show("Pomyślnie edytowano dostawcę w Bazie Danych!");
                            }
                            else
                            {
                                ClearForm();
                                System.Windows.MessageBox.Show("Nie udało się edytować dostawcy z Bazy Danych, ponieważ ma istniejące dowiązania.");
                            }
                        },
                        arg =>
                            Name != "" &&
                            City != "" &&
                            Address != "" &&
                            Phone != "" &
                            Email != "" &&
                            NIP != "" &&
                            Remarks != ""
                   );
                return edit;
            }
        }

        // Obsługa polecenia usuwania dostawcy
        private ICommand del = null;
        public ICommand Del
        {

            get
            {
                if (del == null)
                    del = new RelayCommand(
                        arg =>
                        {
                            if (model.DelSupplier(CurrentSupplier))
                            {
                                ClearForm();
                                System.Windows.MessageBox.Show("Pomyślnie usunięto dostawcę z Bazy Danych!");
                            }
                            else
                            {
                                ClearForm();
                                System.Windows.MessageBox.Show("Nie udało się usunąć dostawcy z Bazy Danych, ponieważ ma istniejące dowiązania.");
                            }
                        },
                        arg =>
                            Name != "" &&
                            City != "" &&
                            Address != "" &&
                            Phone != "" &&
                            Email != "" &&
                            NIP != "" &&
                            Remarks != ""
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
