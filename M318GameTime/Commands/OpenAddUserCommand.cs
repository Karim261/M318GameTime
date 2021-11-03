using M318GameTime.Managers;
using M318GameTime.ViewModels;
using M318GameTime.Views;
using System;
using System.Windows;
using System.Windows.Input;

namespace M318GameTime.Commands
{
    /// <summary>

    public class OpenAddUserCommand : ICommand
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAddCommand"/> class.
        /// </summary>
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
