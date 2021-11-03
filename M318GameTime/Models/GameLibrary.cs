using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Xml.Serialization;

namespace M318GameTime.Models
{

    public class GameLibrary
    {
        private string userLibraryFileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "UserLibrary_M318GameTime.xml");

        #region GameLibrary Constructor

        public GameLibrary()
        {

        }
        #endregion

        #region ObservableCollection of Games
        private ObservableCollection<Game> gamesCollection = new ObservableCollection<Game>();


        public ObservableCollection<Game> GamesCollection
        {
            get
            {
                return gamesCollection;
            }
        }

      
        public void LoadGames()
        {
            GamesCollection.Add(new Game("If You're Reading This It's Too Late", "Drake", "/M318GameTime;component/Images/ifyourereadingthisitstoolate.jpg","01.01.01", "test", "test", "test", "test"));
            GamesCollection.Add(new Game("In Defense of the Genre", "Say Anything", "/M318GameTime;component/Images/indefenseofthegenre.jpg", "01.01.01", "test", "test", "test", "test"));
            GamesCollection.Add(new Game("Picaresque", "The Decemberists", "/M318GameTime;component/Images/picaresque.jpg", "01.01.01", "test", "test", "test", "test"));
            GamesCollection.Add(new Game("In Evening Air", "Future Islands", "/M318GameTime;component/Images/ineveningair.jpg", "01.01.01", "test", "test", "test", "test"));
            GamesCollection.Add(new Game("You're Gonna Miss It All", "Modern Baseball", "/M318GameTime;component/Images/youregonnamissitall.jpg", "01.01.01", "test", "test", "test", "test"));
        }

        
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
