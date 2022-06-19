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
        public ShopsTabModel ShopsTabVM { get; set; }
        public ProductsTabModel ProductsTabVM { get; set; }
        public ClientsTabModel ClientsTabVM { get; set; } 
        public SuppliersTabModel SuppliersTabVM { get; set; }

        public MainViewModel()
        {
            WorkersTabVM = new WorkersTabModel(model);
            ShopsTabVM = new ShopsTabModel(model);
            ProductsTabVM = new ProductsTabModel(model);
            ClientsTabVM = new ClientsTabModel(model);
            SuppliersTabVM = new SuppliersTabModel(model);   
        }
    }
}
