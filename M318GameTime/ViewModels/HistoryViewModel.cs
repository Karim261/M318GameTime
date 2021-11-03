using M318GameTime.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace M318GameTime.ViewModels
{
    public class HistoryViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<History> Histories { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

       
        public HistoryViewModel()
        {
            Histories = new ObservableCollection<History>();
        }

       
        public List<History> getHistories(User user)
        {
            List<History> myTest = new List<History>();
            foreach (History history in Histories)
            {
                if (user.ProfilsPseudo == history.User.ProfilsPseudo)
                {
                    myTest.Add(history);
                }
            }
            return myTest;
        }

        public void AddGame(User user, Game game)
        {
            Histories.Add(new History
            {
                User = user,
                Game = game,
                EtatJeu = EtatJeu.JeuxEnAttente
            });
        }

      
        public void SetJeuxEnCours(History history)
        {
            int i = Histories.IndexOf(history);
            Histories[i].EtatJeu = EtatJeu.JeuxEnCours;
        }

      
        public void SetJeuxTermine(History history)
        {
            int i = Histories.IndexOf(history);
            Histories[i].EtatJeu = EtatJeu.JeuxTermine;
        }

        public void SetJeuxEnAttente(History history)
        {
            int i = Histories.IndexOf(history);
            Histories[i].EtatJeu = EtatJeu.JeuxEnAttente;
        }

        
        public void UpdateGameAll(Game SelectedGame, Game UpdatedGame)
        {
            int i = 0;
            foreach (History history in Histories)
            {
                if (history.Game.JeuxNom == SelectedGame.JeuxNom)
                {
                    Histories[i].Game = UpdatedGame;
                }
                i++;
            }
        }
    }
}