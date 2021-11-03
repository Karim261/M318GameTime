using M318GameTime.ViewModels;
using System.Windows;

namespace M318GameTime.Views
{
    /// <summary>
    /// Code-behind for AddGameView.
    /// </summary>
    /// <seealso cref="System.Windows.Window" />
    public partial class AddGameView : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddGameView"/> class.
        /// </summary>
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
