using Microsoft.Win32;
using System;
using System.Windows.Input;


namespace M318GameTime.Commands
{
  public class BrowseNewJeuxImageCommand : ICommand
    {
      public BrowseNewJeuxImageCommand()
        {

        }

   public bool CanExecute(object parameter)
        {
            return true;
        }

    public void Execute(object parameter)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (openFileDialog.ShowDialog() == true)
            {
                App.Controller.NewJeuxImage = openFileDialog.FileName;
            }

            if (GameAdded != null)
            {
                GameAdded(this, EventArgs.Empty);
            }
        }

        public event EventHandler GameAdded;


        public event EventHandler CanExecuteChanged;

    }
}
