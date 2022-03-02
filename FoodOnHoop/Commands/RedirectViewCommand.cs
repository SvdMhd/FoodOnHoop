using FoodOnHoop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FoodOnHoop.Commands
{
    public class RedirectViewCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public MainViewModel mainview;
        public RedirectViewCommand(MainViewModel viewModel)
        {
            this.mainview = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter.ToString() == "Home")
            {
                mainview.SelectViewModel = new HomeViewModel();
            }
            else if (parameter.ToString() == "AllTimeChillers")
            {
                mainview.SelectViewModel = new AllTimeChillersViewModel();
            }
            else if (parameter.ToString() == "ContactUs")
            {
                mainview.SelectViewModel = new ContactUsViewModel();
            }
            else if (parameter.ToString() == "AboutUs")
            {
                mainview.SelectViewModel = new AboutUsViewModel();
            }
            else if (parameter.ToString() == "FoodOnMood")
            {
                mainview.SelectViewModel = new FoodOnMoodViewModel();
            }
            else if (parameter.ToString() == "HotClassic")
            {
                mainview.SelectViewModel = new HotClassicViewModel();
            }
            else if (parameter.ToString() == "Login")
            {
                mainview.SelectViewModel = new LoginViewModel();
            }
            //else if (parameter.ToString() == "SignUp")
            //{
            //    mainview.SelectViewModel = new LoginViewModel();
            //}
        }
    }
}
