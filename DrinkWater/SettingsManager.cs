using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DrinkWater
{
    class SettingsManager
    {
        public void SetTimeInterval()
        {
            

        }

        private void one_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            TimeSpan periodTimeSpan = TimeSpan.FromMinutes(60);

        }

        private void onehalf_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            TimeSpan periodTimeSpan = TimeSpan.FromMinutes(90);
        }

        private void two_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            TimeSpan periodTimeSpan = TimeSpan.FromMinutes(120);
        }

        private void twohalf_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            TimeSpan periodTimeSpan = TimeSpan.FromMinutes(150);
        }

        private void three_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            TimeSpan periodTimeSpan = TimeSpan.FromMinutes(180);
        }

        private void threehalf_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            TimeSpan periodTimeSpan = TimeSpan.FromMinutes(210);
        }
        private void four_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            TimeSpan periodTimeSpan = TimeSpan.FromMinutes(240);
        }

    }
}
        
   