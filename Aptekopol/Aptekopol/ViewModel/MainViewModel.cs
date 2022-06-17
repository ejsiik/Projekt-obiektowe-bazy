using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aptekopol.ViewModel
{
    using Aptekopol.Model;

    internal class MainViewModel
    {
        // Instancja modelu
        private Model model = new Model();
        public WorkersTabModel WorkersTabVM { get; set; }

        public MainViewModel()
        {
            WorkersTabVM = new WorkersTabModel(model);
        }
    }
}
