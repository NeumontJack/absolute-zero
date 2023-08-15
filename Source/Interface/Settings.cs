﻿using AbsoluteZero.Properties;
using System;
using System.Threading;
using System.Windows.Forms;

namespace AbsoluteZero {

    /// <summary>
    /// Represents a settings dialog box. 
    /// </summary>
    partial class Settings : Form {

        /// <summary>
        /// Constructs a Settings window. 
        /// </summary>
        public Settings() {
            InitializeComponent();
            Icon = Resources.Icon;
        }

        /// <summary>
        /// Handles the Start button click. 
        /// </summary>
        /// <param name="sender">The sender of the event.</param>
        /// <param name="e">The raised event.</param>
        private void StartClick(Object sender, EventArgs e) {

            // Open the GUI interface only if both players have been chosen. 
            if ((whiteHuman.Checked || whiteComputer.Checked) && (blackHuman.Checked || blackComputer.Checked)) {
                IPlayer white = whiteHuman.Checked ? new Human() : new Engine() as IPlayer;
                IPlayer black = blackHuman.Checked ? new Human() : new Engine() as IPlayer;

                // If both players are human there's no need for the Engine Output window. 
                if (white is Human && black is Human)
                    Terminal.Hide();
                else
                    Restrictions.MoveTime = 3000;

                // Display the GUI window and hide this window. 
                new Window() { Game = new Game(white, black) }.Show();
                Visible = false;
                ShowInTaskbar = false;
            } else
                MessageBox.Show("Please select a player for each side.");
        }

        /// <summary>
        /// Handles the Analysis Mode button click. 
        /// </summary>
        /// <param name="sender">The sender of the event.</param>
        /// <param name="e">The mouse event.</param>
        private void AnalysisModeClick(Object sender, EventArgs e) {
            AnalysisBox analysisBox = new AnalysisBox();

            new Thread(new ThreadStart(() => {
                Application.Run(new Window() { AnalysisBox = analysisBox });
            })) {
                IsBackground = true
            }.Start();

            analysisBox.Show();
            Visible = false;
            ShowInTaskbar = false;
        }

        private void Chess960_Click(object sender, EventArgs e)
        {
            if ((whiteHuman.Checked || whiteComputer.Checked) && (blackHuman.Checked || blackComputer.Checked))
            {
                IPlayer white = whiteHuman.Checked ? new Human() : new Engine() as IPlayer;
                IPlayer black = blackHuman.Checked ? new Human() : new Engine() as IPlayer;

                // If both players are human there's no need for the Engine Output window. 
                if (white is Human && black is Human)
                    Terminal.Hide();
                else
                    Restrictions.MoveTime = 3000;

                // Display the GUI window and hide this window. 
                new Window() { Game = new Game(white, black) }.Show();
                Visible = false;
                ShowInTaskbar = false;
            }
            else
                MessageBox.Show("Please select a player for each side.");
        }
    }
}
