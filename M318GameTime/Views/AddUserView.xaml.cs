using M318GameTime.ViewModels;
using System.Windows;

namespace M318GameTime.Views
{

    public partial class AddUserView : Window
    {
      
        public AddUserView()
        {
            InitializeComponent();

            AddUserViewModel viewModel = new AddUserViewModel();
            this.DataContext = viewModel;
        }
    }
}
