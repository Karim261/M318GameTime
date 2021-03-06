using M318GameTime.Models;
using System;
using System.Windows.Input;

namespace M318GameTime.Commands
{

    public class UpdateProfilsMotPasseCommand : ICommand, IDisposable
    {

        public event EventHandler UserAdded;
        public event EventHandler CanExecuteChanged;

        public UpdateProfilsMotPasseCommand()
        {
            App.Controller.PropertyChanged += onControllerPropertyChanged;
        }

        public bool CanExecute(object parameter)
        {
            if (String.IsNullOrEmpty(App.Controller.UpdatedProfilsMotPasse))
                return false;

            return true;
        }

        public void Execute(object parameter)
        {


            User newUser = new User(App.Controller.SelectedUser.ProfilsPseudo, App.Controller.SelectedUser.ProfilsNom, App.Controller.SelectedUser.ProfilsPrenom, App.Controller.SelectedUser.ProfilsDateNaissance, App.Controller.SelectedUser.ProfilsEmail, App.Controller.UpdatedProfilsMotPasse);
            User oldSelectedUser = App.Controller.SelectedUser;

            App.Controller.AddUser(newUser);
            App.Controller.SelectedUser = newUser;
            App.Controller.RemoveUser(oldSelectedUser);

            if (UserAdded != null)
            {
                UserAdded(this, EventArgs.Empty);
            }
        }

        private void onControllerPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "UpdatedProfilsMotPasse")
            {
                if (CanExecuteChanged != null)
                {
                    CanExecuteChanged(this, EventArgs.Empty);
                }
            }
        }

        public void Dispose()
        {
            App.Controller.PropertyChanged -= onControllerPropertyChanged;
        }
    }
}
