using M318GameTime.ViewModels;
using System.Windows;

namespace M318GameTime.Views
{
    /// <summary>
    /// Code-behind for AddUserView.
    /// </summary>
    /// <seealso cref="System.Windows.Window" />
    public partial class AddUserView : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddUserView"/> class.
        /// </summary>
        public AddUserView()
        {
            InitializeComponent();

            AddUserViewModel viewModel = new AddUserViewModel();
            this.DataContext = viewModel;
        }
    }
}
