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

    internal class ClientsTabModel : ViewModelBase
    {
        #region Attributes 
        private Model model = null;

        // Obsługa listy sklepów
        private ObservableCollection<Client> clients = null;
        private int selectedClientIndex = -1;

        // Obsługa szczegółów
        private int id;
        private bool is_company;
        private DateTime password_last_change;
        private string login, fistname, surname, name, nip, city, address, phone, email, password;
        private DateTime dataNow = DateTime.Now;

        // Obsługa przycisków szczegółów
        private bool addStatus = true, editStatus = false, delStatus = false;
        #endregion

        #region Constructor
        public ClientsTabModel(Model model) 
        {
            this.model = model;
            this.clients = model.ClientsCollection;
        }
        #endregion

        #region Methods
        public Client CurrentClient { get; set; }

        public ObservableCollection<Client> Clients
        {
            get { return this.clients; }
            set
            {
                this.clients = value;
                
                onPropertyChanged(nameof(Clients));
            }
        }

        public int SelectedClientIndex
        {
            get => selectedClientIndex;
            set
            {
                selectedClientIndex = value;
                onPropertyChanged(nameof(SelectedClientIndex));
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
            Login = "";
            Firstname = "";
            Surname = "";
            Is_company = false;
            Name = "";
            NIP = "";
            City = "";
            Address = "";
            Phone = "";
            Email = "";
            Password = "";
            Password_last_change = dataNow;

            AddStatus = true;
            EditStatus = false;
            DelStatus = false;
        }
        #endregion

        #region Properties
        public string Login
        {
            get { return login; }
            set
            {
                login = value;
                onPropertyChanged(nameof(Login));
            }
        }

        public string Firstname
        {
            get { return fistname; }
            set
            {
                fistname = value;
                onPropertyChanged(nameof(Firstname));
            }
        }

        public string Surname
        {
            get { return surname; }
            set
            {
                surname = value;
                onPropertyChanged(nameof(Surname));
            }
        }

        public bool Is_company
        {
            get { return is_company; }
            set
            {
                is_company = value;
                onPropertyChanged(nameof(Is_company));
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

        public string NIP
        {
            get { return nip; }
            set
            {
                nip = value;
                onPropertyChanged(nameof(NIP));
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

        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                onPropertyChanged(nameof(Password));
            }
        }

        public DateTime Password_last_change
        {
            get { return password_last_change; }
            set
            {
                password_last_change = value;
                onPropertyChanged(nameof(Password_last_change));
            }
        }
        #endregion

        #region Commands
        // Załadowywanie pracowników
        private ICommand loadAllClients = null;
        public ICommand LoadAllClients
        {
            get
            {
                if (loadAllClients == null)
                    loadAllClients = new RelayCommand(
                        arg =>
                        {
                            Clients = model.ClientsCollection;
                            selectedClientIndex = -1;
                        },
                        arg => true
                        );

                return loadAllClients;
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
                            if (SelectedClientIndex > -1)
                            {
                                Login = CurrentClient.Login;
                                Firstname = CurrentClient.Firstname;
                                Surname = CurrentClient.Surname;
                                Is_company = CurrentClient.IsCompany;
                                Name = CurrentClient.Name;
                                NIP = CurrentClient.NIP;
                                City = CurrentClient.City;
                                Address = CurrentClient.Address;
                                Phone = CurrentClient.Phone;
                                Email = CurrentClient.Email;
                                Password = CurrentClient.Password;
                                Password_last_change = CurrentClient.PasswordLastChange;

                                AddStatus = false;
                                EditStatus = true;
                                DelStatus = true;
                            }
                            else
                                ClearForm();
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
                            var shop = new Client(Login, Firstname, Surname, Is_company, Name, NIP, City, Address, Phone, Email, Password, Password_last_change);

                            if (model.AddClient(shop))
                            {
                                ClearForm();
                                System.Windows.MessageBox.Show("Pomyślnie dodano nowego klienta do Bazy Danych!");
                            }
                        },
                        arg =>
                            Login != "" &&
                            Firstname != "" &&
                            Surname != "" &&
                            Is_company != false &&
                            Name != "" &&
                            NIP != "" &&
                            City != "" &&
                            Address != "" &&
                            Phone != "" &&
                            Email != "" &&
                            Password != "" &&
                            Password_last_change != dataNow
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
                            if (model.EditClient(new Client(Login, Firstname, Surname, Is_company, Name, NIP, City, Address, Phone, Email, Password, Password_last_change), (int)CurrentClient.ID))
                            {
                                ClearForm();
                                System.Windows.MessageBox.Show("Pomyślnie edytowano klienta w Bazie Danych!");
                            }
                        },
                        arg =>
                            Login != "" &&
                            Firstname != "" &&
                            Surname != "" &&
                            Is_company != false &&
                            Name != "" &&
                            NIP != "" &&
                            City != "" &&
                            Address != "" &&
                            Phone != "" &&
                            Email != "" &&
                            Password != "" &&
                            Password_last_change != dataNow
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
                            if (model.DelClient(CurrentClient))
                            {
                                ClearForm();
                                System.Windows.MessageBox.Show("Pomyślnie usunięto klienta z Bazy Danych!");
                            } else
                            {
                                ClearForm();
                                System.Windows.MessageBox.Show("Nie udało się usunąć klienta z Bazy Danych");
                            }
                        },
                        arg =>
                            Login != "" &&
                            Firstname != "" &&
                            Surname != "" &&
                            Is_company != false &&
                            Name != "" &&
                            NIP != "" &&
                            City != "" &&
                            Address != "" &&
                            Phone != "" &&
                            Email != "" &&
                            Password != "" &&
                            Password_last_change != dataNow
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
