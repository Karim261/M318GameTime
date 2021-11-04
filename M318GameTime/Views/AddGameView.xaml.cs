using M318GameTime.ViewModels;
using System.Windows;
using System.Collections.Generic; 

using M318GameTime.Models;

namespace M318GameTime.Views
{

    public partial class AddGameView : Window
    {
        History h = new History();
        public AddGameView()
        {
            InitializeComponent();

            AddGameViewModel viewModel = new AddGameViewModel();
            this.DataContext = viewModel;

        }


        private void addGameBtn_Click(object sender, RoutedEventArgs e)
        {
             if (HistoryComboBox.Text == "Jeux En Attente")
            {
                h.EtatJeu = EtatJeu.JeuxEnAttente;
            }
             else if (HistoryComboBox.Text == "Jeux En Cours")
            {
                h.EtatJeu = EtatJeu.JeuxEnCours;

            }
            else
            {
                h.EtatJeu = EtatJeu.JeuxTermine;

            }
        }

        private void ComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
    }
}
