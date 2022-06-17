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

        #endregion

    }
}
