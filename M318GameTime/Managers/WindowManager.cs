using System.Windows;

namespace M318GameTime.Managers
{
    /// <summary>
    /// Manages the windows for AddGameWindow and ViewGameWindow
    /// </summary>
    public class WindowManager
    {
        /// <summary>
        /// Gets or sets the add game window.
        /// </summary>
        /// <value>
        /// The add game window.
        /// </value>
        public static Window AddGameWindow
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the view game window.
        /// </summary>
        /// <value>
        /// The view game window.
        /// </value>
        public static Window ViewGameWindow
        {
            get;
            set;
        }

        public static Window AddUserWindow
        {
            get;
            set;
        }

        public static Window ViewUserWindow
        {
            get;
            set;
        }
    }
}
