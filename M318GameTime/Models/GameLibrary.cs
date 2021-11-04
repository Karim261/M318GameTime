using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Xml.Serialization;

namespace M318GameTime.Models
{

    public class GameLibrary
    {
        private string gameLibraryFileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "GameLibrary_M318GameTime.xml");

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
            GamesCollection.Add(new Game("Hitman", "Nice Game", "/M318GameTime;component/Images/hitman.png", "01/04/2021", "Action", "18+", "Xbox", "English"));
            GamesCollection.Add(new Game("Mario", "Nice Game", "/M318GameTime;component/Images/mario.jpg", "04/11/2020", "Action", "7+", "Nintendo", "English"));
            GamesCollection.Add(new Game("Call of duty", "Nice Game", "/M318GameTime;component/Images/call_of_duty_modern_warfare.png", "07/01/2021", "English", "16+", "PS", "English"));
            GamesCollection.Add(new Game("Lord of Rings", "Nice Game", "/M318GameTime;component/Images/LOTR.jpg", "09/08/2018", "Action", "12+", "PC", "English"));
            GamesCollection.Add(new Game("Fifa 22", "Nice Game", "/M318GameTime;component/Images/fifa22.jpg", "03/01/2020", "Sport", "7+", "PS", "English"));
        }

        
        public void Load()
        {
            if (File.Exists(gameLibraryFileName))
            {
                XmlSerializer xs = new XmlSerializer(typeof(ObservableCollection<Game>));

                using (StreamReader reader = new StreamReader(gameLibraryFileName))
                {
                    this.gamesCollection = (ObservableCollection<Game>)xs.Deserialize(reader);
                }
            }

            else
            {
                LoadGames();
        }
    }

       
        public void Save()
        {
            XmlSerializer xs = new XmlSerializer(typeof(ObservableCollection<Game>));

            using (StreamWriter writer = new StreamWriter(gameLibraryFileName))
            {
                xs.Serialize(writer, this.gamesCollection);
            }
        }
        #endregion
    }
}
