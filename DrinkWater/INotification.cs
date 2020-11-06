using System;
using System.Collections.Generic;
using System.Text;

namespace DrinkWater
{
     public interface INotification
    {
        event EventHandler NotificationReceived;

        void CreateNotification(String title, String message);
       
    }
}
