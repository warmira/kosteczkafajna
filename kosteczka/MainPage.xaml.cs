﻿namespace kosteczka
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            Random r = new Random();
            int diceRoll = r.Next(1, 7);
            CounterBtn.Text = "Wynik rzutu: " + diceRoll.ToString();
        }
    }

}
