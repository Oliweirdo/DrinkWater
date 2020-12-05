using DrinkWater.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DrinkWater.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SetPage : ContentPage
    {
        readonly INotificationManager notificationManager;
        DateTime _triggerTime;
        public SetPage()
        {
            InitializeComponent();

            Device.StartTimer(TimeSpan.FromSeconds(1), OnTimerTick);

            notificationManager = DependencyService.Get<INotificationManager>();
            notificationManager.NotificationReceived += (sender, eventArgs) =>
            {
                var evtData = (NotificationEventArgs)eventArgs;
                ShowNotification(evtData.Title, evtData.Message);
            };
        }
         bool OnTimerTick()
        {

            if (_switch.IsToggled && DateTime.Now >= _triggerTime)
                {
                _switch.IsToggled = false;
                DisplayAlert("Alert", "Time to drink water :)", "OK");
                string title = $"Drink Water";
                string message = $"Time to drink water :)";
                notificationManager.ScheduleNotification(title, message);
                // Use default vibration length
                Vibration.Vibrate();

                // Or use specified time
                var duration = TimeSpan.FromSeconds(1);
                Vibration.Vibrate(duration);
            }
            return true;
        }

        void OnTimePickerPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            if (args.PropertyName == "Time")
            {
                SetTriggerTime();
            }
        }
        void OnSwitchToggled(object sender, ToggledEventArgs args)
        {
            SetTriggerTime();
        }
        void SetTriggerTime()
        {
            if (_switch.IsToggled)
            {
                _triggerTime = DateTime.Today + _timePicker.Time;
                if (_triggerTime < DateTime.Now)
                {
                    _triggerTime += TimeSpan.FromDays(1);
                }
            }
        }

            void ShowNotification(string title, string message)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                var msg = new Label()
                {
                    Text = $"Notification Received:\nTitle: {title}\nMessage: {message}"
                };

            });
        }
    }
}