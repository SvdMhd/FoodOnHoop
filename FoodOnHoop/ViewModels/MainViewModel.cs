using FoodOnHoop.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FoodOnHoop.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private BaseViewModel _selectViewModel = new HomeViewModel();
        public MainViewModel()
        {
            RedirectViewCommands = new RedirectViewCommand(this);
        }
        public BaseViewModel SelectViewModel
        {
            get { return _selectViewModel; }
            set { _selectViewModel = value; OnPropertyChanged(nameof(SelectViewModel)); }
        }
        public ICommand RedirectViewCommands { get; set; }
    }
}
