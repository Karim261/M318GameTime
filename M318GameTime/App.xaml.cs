using M318GameTime.ViewModels;
using M318GameTime.Models;
using System.Windows;

namespace M318GameTime
{
    /// <summary>
    /// Code-behind for App view.
    /// </summary>
    /// <seealso cref="System.Windows.Application" />
    public partial class App : Application
    {
        public static MainViewModel Controller;
        private static GameLibrary gameLibrary;
        private static UserLibrary userLibrary;

        /// <summary>
        /// Initializes a new instance of the <see cref="App"/> class.
        /// Sets gameLibrary to be shared throughout application.
        /// When the app opens, loads the XML file to populate ObservableCollection.
        /// </summary>
        public App()
        {
            App.gameLibrary = new GameLibrary();
            App.gameLibrary.Load();
            App.userLibrary = new UserLibrary();
            App.userLibrary.Load();

            App.Controller = new MainViewModel(App.gameLibrary, App.userLibrary);
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Application.Exit" /> event.
        /// When the app closes, saves contents of ObservableCollection to XML file.
        /// </summary>
        /// <param name="e">An <see cref="T:System.Windows.ExitEventArgs" /> that contains the event data.</param>
        protected override void OnExit(ExitEventArgs e)
        {
            App.gameLibrary.Save();
            App.userLibrary.Save();
            base.OnExit(e);
        }
    }
}
