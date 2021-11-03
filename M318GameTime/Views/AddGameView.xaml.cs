using M318GameTime.ViewModels;
using System.Windows;

namespace M318GameTime.Views
{

    public partial class AddGameView : Window
    {
   
        public AddGameView()
        {
            InitializeComponent();

            AddGameViewModel viewModel = new AddGameViewModel();
            this.DataContext = viewModel;
        }

        private void addGameBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
    }
}
