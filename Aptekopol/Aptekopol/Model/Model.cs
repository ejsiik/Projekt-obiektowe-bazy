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
        #endregion

        #region Constructors
        //Pobranie danych z BD do kolekcji
        public Model()
        {
            var workers = Workers.GetAllWorkers();
            foreach (var w in workers)
                WorkersCollection.Add(w);
        }
        #endregion

        #region Methods
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
                worker.ID = (sbyte?)(id + 1);
                WorkersCollection[id] = new Worker(worker);
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

    }
}
