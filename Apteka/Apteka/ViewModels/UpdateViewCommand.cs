using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Apteka.ViewModels
{
    public class UpdateViewCommand: ICommand
    {
        private MainWindowViewModel viewModel;

        public UpdateViewCommand(MainWindowViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }
        public void Execute(object parameter)
        {
           if(parameter.ToString() == "Pracownik")
            {
                viewModel.SelectedViewModel = new SellerViewModel();
            }
            else if (parameter.ToString() == "Klient")
            {
                viewModel.SelectedViewModel = new UserViewModel();
            }
            else if (parameter.ToString() == "Magazynier")
            {
                viewModel.SelectedViewModel = new StoreManagerViewModel();
            }
            else if (parameter.ToString() == "Regionalny kierownik")
            {
                viewModel.SelectedViewModel = new RegionalManagerViewModel();
            }
            else if (parameter.ToString() == "Menu")
            {
                viewModel.SelectedViewModel = new MainWindowViewModel();
            }
        }
  
     }
    
}
