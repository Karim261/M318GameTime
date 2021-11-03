using M318GameTime.ViewModels;
using M318GameTime.Views;
using System.Windows;

namespace M318GameTime
{
    /// <summary>
    /// Code-behind for MainWindow view.
    /// </summary>
    /// <seealso cref="System.Windows.Window" />
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// Sets data context to MainWindow.
        /// </summary>
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
