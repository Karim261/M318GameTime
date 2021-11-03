using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Xml.Serialization;

namespace M318GameTime.Models
{
    /// <summary>
    /// GameLibrary model.
    /// </summary>
    public class GameLibrary
    {
        private string userLibraryFileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "UserLibrary_M318GameTime.xml");

        #region GameLibrary Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="GameLibrary"/> class.
        /// </summary>
        public GameLibrary()
        {

        }
        #endregion

        #region ObservableCollection of Games
        private ObservableCollection<Game> gamesCollection = new ObservableCollection<Game>();

        /// <summary>
        /// Gets the games collection.
        /// </summary>
        /// <value>
        /// The games collection.
        /// </value>
        public ObservableCollection<Game> GamesCollection
        {
            get
            {
                return gamesCollection;
            }
        }

        /// <summary>
        /// Loads pre-created games (for demonstration purposes; this method and associated images can be removed).
        /// </summary>
        public void LoadGames()
        {
            GamesCollection.Add(new Game("If You're Reading This It's Too Late", "Drake", "/M318GameTime;component/Images/ifyourereadingthisitstoolate.jpg","test", "test", "test", "test", "test"));
            GamesCollection.Add(new Game("In Defense of the Genre", "Say Anything", "/M318GameTime;component/Images/indefenseofthegenre.jpg", "test", "test", "test", "test", "test"));
            GamesCollection.Add(new Game("Picaresque", "The Decemberists", "/M318GameTime;component/Images/picaresque.jpg", "test", "test", "test", "test", "test"));
            GamesCollection.Add(new Game("In Evening Air", "Future Islands", "/M318GameTime;component/Images/ineveningair.jpg", "test", "test", "test", "test", "test"));
            GamesCollection.Add(new Game("You're Gonna Miss It All", "Modern Baseball", "/M318GameTime;component/Images/youregonnamissitall.jpg", "test", "test", "test", "test", "test"));
        }

        /// <summary>
        /// Loads user library of games from the XML file.
        /// </summary>
        public void Load()
        {
            //if (File.Exists(userLibraryFileName))
            //{
            //    XmlSerializer xs = new XmlSerializer(typeof(ObservableCollection<Game>));

            //    using (StreamReader reader = new StreamReader(userLibraryFileName))
            //    {
            //        this.gamesCollection = (ObservableCollection<Game>)xs.Deserialize(reader);
            //    }
            //}

            //else
            //{
                LoadGames();
            //}
        }

        /// <summary>
        /// Saves user library of games to the XML file.
        /// </summary>
        public void Save()
        {
            XmlSerializer xs = new XmlSerializer(typeof(ObservableCollection<Game>));

            using (StreamWriter writer = new StreamWriter(userLibraryFileName))
            {
                xs.Serialize(writer, this.gamesCollection);
            }
        }
        #endregion
    }
}
