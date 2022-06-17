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

    internal class WorkersTabModel : ViewModelBase
    {
        #region Attributes 
        private Model model = null;

        // Obsługa listy pracowników
        private ObservableCollection<Worker> workers = null;
        private int selectedWorkerIndex = -1;

        // Obsługa szczegółów pracownika
        private int id;
        private string firstname, surname, city, address, phone, email, pesel;

        // Obsługa przycisków szczegółów pracownika
        private bool addStatus = true, editStatus = false, delStatus = false;
        #endregion

        #region Constructors
        public WorkersTabModel(Model model) 
        {
            this.model = model;
            this.workers = model.WorkersCollection;
        }
        #endregion

        #region Methods
        public Worker CurrentWorker { get; set; }

        public ObservableCollection<Worker> Workers
        {
            get { return this.workers; }
            set
            {
                this.workers = value;
                
                onPropertyChanged(nameof(Workers));
            }
        }

        public int SelectedWorkerIndex
        {
            get => selectedWorkerIndex;
            set
            {
                selectedWorkerIndex = value;
                onPropertyChanged(nameof(SelectedWorkerIndex));
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
            Firstname = "";
            Surname = "";
            City = "";
            Address = "";
            Phone = "";
            Email = "";
            PESEL = "";
            SelectedWorkerIndex = -1;
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

        public string Firstname
        {
            get { return firstname; }
            set
            {
                firstname = value;
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

        public string PESEL
        {
            get { return pesel; }
            set
            {
                pesel = value;
                onPropertyChanged(nameof(PESEL));
            }
        }
        #endregion

        #region Commands
        // Załadowywanie pracowników
        private ICommand loadAllWorkers = null;
        public ICommand LoadAllWorkers
        {
            get
            {
                if (loadAllWorkers == null)
                    loadAllWorkers = new RelayCommand(
                        arg =>
                        {
                            Workers = model.WorkersCollection;
                            selectedWorkerIndex = -1;
                        },
                        arg => true
                        );

                return loadAllWorkers;
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
                            if (SelectedWorkerIndex > -1)
                            {
                                Firstname = CurrentWorker.Firstname;
                                Surname = CurrentWorker.Surname;
                                City = CurrentWorker.City;
                                Address = CurrentWorker.Address;
                                Phone = CurrentWorker.Phone;
                                Email = CurrentWorker.Email;
                                PESEL = CurrentWorker.PESEL;
                                AddStatus = false;
                                EditStatus = true;
                                DelStatus = true;
                            }
                            else
                            {
                                Firstname = "";
                                Surname = "";
                                City = "";
                                Address = "";
                                Phone = "";
                                Email = "";
                                PESEL = "";
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

        // Obsługa polecenia dodawania pracownika
        private ICommand add = null;
        public ICommand Add
        {
            get
            {
                if (add == null)
                    add = new RelayCommand(
                        arg =>
                        {
                            var worker = new Worker(Firstname, Surname, City, Address, Phone, Email, PESEL);

                            if (model.AddWorker(worker))
                            {
                                ClearForm();
                                System.Windows.MessageBox.Show("Pomyślnie dodano nowego pracownika do Bazy Danych!");
                            }
                        },
                        arg => 
                            Firstname != "" &&
                            Surname != "" &&
                            City != "" &&
                            Address != "" &&
                            Phone != "" &&
                            Email != "" &&
                            PESEL != ""
                    );

                return add;
            }

        }

        // Obsługa polecenia edycji pracownika
        private ICommand edit = null;
        public ICommand Edit
        {
            get
            {
                if (edit == null)
                    edit = new RelayCommand(
                        arg =>
                        {
                            if (model.EditWorker(new Worker(Firstname, Surname, City, Address, Phone, Email, PESEL), ID))
                            {
                                ClearForm();
                                System.Windows.MessageBox.Show("Pomyślnie edytowano pracownika w Bazie Danych!");
                            }
                        },
                        arg =>
                            Firstname != "" &&
                            Surname != "" &&
                            City != "" &&
                            Address != "" &&
                            Phone != "" &
                            Email != "" &&
                            PESEL != ""
                   );
                return edit;
            }
        }

        // Obsługa polecenia usuwania pracownika
        private ICommand del = null;
        public ICommand Del
        {

            get
            {
                if (del == null)
                    del = new RelayCommand(
                        arg =>
                        {
                            if (model.DelWorker(CurrentWorker))
                            {
                                ClearForm();
                                System.Windows.MessageBox.Show("Pomyślnie usunięto pracownika do Bazy Danych!");
                            }
                        },
                        arg =>
                            Firstname != "" &&
                            Surname != "" &&
                            City != "" &&
                            Address != "" &&
                            Phone != "" &&
                            Email != "" &&
                            PESEL != ""
                    );

                return del;
            }

        }
        #endregion
    }
}
