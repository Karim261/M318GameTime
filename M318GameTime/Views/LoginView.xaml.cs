using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using M318GameTime.ViewModels;
using M318GameTime.Models;


namespace M318GameTime.Views
{
    public partial class LoginView : Window
    {
        public LoginView()
        {
            InitializeComponent();
        }


        AddUserViewModel m = new AddUserViewModel();


        private void goToMainWindowBtn_Click(object sender, RoutedEventArgs e)
        {
            string test = ProfiPasseTextBox.Text;

            MainWindow window = new MainWindow();
            

            

            if ("admin" == ProfiPasseTextBox.Text && "admin" == ProfilsMotPasseTextBox.Text) { 
                window.Show();
            }

            else
            {
                string message = "Your username or password is wrong! (try admin)";
                string title = "Erreur";
                MessageBox.Show(message, title);
            }

        }
    }
}
