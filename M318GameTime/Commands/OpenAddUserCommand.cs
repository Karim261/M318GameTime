using M318GameTime.Managers;
using M318GameTime.ViewModels;
using M318GameTime.Views;
using System;
using System.Windows;
using System.Windows.Input;

namespace M318GameTime.Commands
{


    public class OpenAddUserCommand : ICommand
    {

        public OpenAddUserCommand()
        {
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

       public void Execute(object parameter)
        {
            Window newAddUserView = new AddUserView();
            WindowManager.AddUserWindow = newAddUserView;

            AddUserViewModel newAddUserViewModel = new AddUserViewModel();
            newAddUserView.DataContext = newAddUserViewModel;

            newAddUserView.ShowDialog();

            newAddUserView.DataContext = null;
            newAddUserViewModel.Dispose();
        }
        public event EventHandler CanExecuteChanged;
    }
}
