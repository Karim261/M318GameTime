﻿using M318GameTime.Managers;
using M318GameTime.ViewModels;
using M318GameTime.Views;
using System;
using System.Windows;
using System.Windows.Input;

namespace M318GameTime.Commands
{
    /// <summary>
    /// Opens the View/Update/Delete window.
    /// </summary>
    /// <seealso cref="System.Windows.Input.ICommand" />
    public class OpenViewCommand : ICommand
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OpenViewCommand"/> class.
        /// </summary>
        public OpenViewCommand()
        {
        }

        /// <summary>
        /// Defines the method that determines whether the command can execute in its current state.
        /// </summary>
        /// <param name="parameter">Data used by the command.  If the command does not require data to be passed, this object can be set to null.</param>
        /// <returns>
        /// true if this command can be executed; otherwise, false.
        /// </returns>
        public bool CanExecute(object parameter)
        {
            return true;
        }

        /// <summary>
        /// Defines the method to be called when the command is invoked.
        /// Opens View/Update/Delete window.
        /// </summary>
        /// <param name="parameter">Data used by the command.  If the command does not require data to be passed, this object can be set to null.</param>
        public void Execute(object parameter)
        {
            Window newViewGameView = new UpdateorDeleteView();
            WindowManager.ViewGameWindow = newViewGameView;


            UpdateOrDeleteViewModel newUpdateOrDeleteViewModel = new UpdateOrDeleteViewModel();
            newViewGameView.DataContext = newUpdateOrDeleteViewModel;

            newViewGameView.ShowDialog();

            newViewGameView.DataContext = null;
            newUpdateOrDeleteViewModel.Dispose();
        }

#pragma warning disable 67
        public event EventHandler CanExecuteChanged;
#pragma warning restore 67
    }
}
