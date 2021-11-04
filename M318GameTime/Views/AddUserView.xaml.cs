using M318GameTime.ViewModels;
using System.Windows;
using System.Collections.Generic; 


namespace M318GameTime.Views
{

    public partial class AddUserView : Window
    {

        List<string> nomLog = new List<string>();
        List<string> MDPLog = new List<string>();

      
        public AddUserView()
        {
            InitializeComponent();

            AddUserViewModel viewModel = new AddUserViewModel();
            this.DataContext = viewModel;
        }

        private void addUserBtn_Click(object sender, RoutedEventArgs e)
        {
            string MDP = ProfilsMotPasseTextBox.Text;
            string Pseudo = ProfilsPseudoTextBox.Text;

            nomLog.Add(Pseudo);
            MDPLog.Add(MDP);
        }
                public List<string> GetList()
    {
        return nomLog;
    }

        public List<string> GetList2()
    {
        return MDPLog;
    }
    }
}
