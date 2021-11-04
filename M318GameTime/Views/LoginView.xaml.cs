﻿using System;
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
            string test2 = ProfilsMotPasseTextBox.Text;

            MainWindow window = new MainWindow();

            AddUserView ul = new AddUserView();
            
            List<String> calledList1 = ul.GetList();
            List<String> calledList2 = ul.GetList2();
            

            

            if ("admin" == ProfiPasseTextBox.Text && "admin" == ProfilsMotPasseTextBox.Text) { 
                window.Show();
            }

            else if (calledList1.Any(o => o == test) && calledList2.Any(k => k == test2))
            {
                window.Show();
            }

            else
            {
                string message = "Identifian ou mot de passe incorrect";
                string title = "Erreur";
                MessageBox.Show(message, title);
            }

        }
    }
}
