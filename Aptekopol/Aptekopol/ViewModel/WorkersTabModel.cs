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
        #region Properties
        private Model model = null;
        private ObservableCollection<Worker> workers = null;

        private int selectedWorkerIndex = -1;
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
        #endregion
    }
}
