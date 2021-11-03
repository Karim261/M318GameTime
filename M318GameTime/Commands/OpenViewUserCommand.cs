using M318GameTime.Managers;
using M318GameTime.ViewModels;
using M318GameTime.Views;
using System;
using System.Windows;
using System.Windows.Input;

namespace M318GameTime.Commands
{

    public class OpenViewUserCommand : ICommand
    {

        public OpenViewUserCommand()
        {
        }

 public bool CanExecute(object parameter)
        {
            return true;
        }

      public void Execute(object parameter)
        {
            Window newViewUserView = new UpdateorDeleteUserView();
            WindowManager.ViewUserWindow = newViewUserView;


            UpdateOrDeleteUserViewModel newUpdateOrDeleteUserViewModel = new UpdateOrDeleteUserViewModel();
            newViewUserView.DataContext = newUpdateOrDeleteUserViewModel;

            newViewUserView.ShowDialog();

            newViewUserView.DataContext = null;
            newUpdateOrDeleteUserViewModel.Dispose();
        }


        public event EventHandler CanExecuteChanged;

    }
}
