using M318GameTime.ViewModels;
using M318GameTime.Views;
using System.Windows;

namespace M318GameTime
{
    
    public partial class MainWindow : Window
    {
    
        public MainWindow()
        {
            InitializeComponent();

            MainWindowViewModel viewModel = new MainWindowViewModel();

            this.DataContext = viewModel;
            
        }

        private void AddWindowBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ViewUserWindowBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddRelationsBtn_Click(object sender, RoutedEventArgs e)
        {
            UserGameView v = new UserGameView();
            v.Show();
        }
    }
}
