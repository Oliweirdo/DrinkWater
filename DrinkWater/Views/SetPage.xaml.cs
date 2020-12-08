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
        DateTime _triggerTimeEnd;
        int _repeatTime;
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
                string title = $"Drink Water";
                string message = $"Time to drink water :)";
                notificationManager.ScheduleNotification(title, message);

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
                SetTriggerTimeEnd();
            }
        }
        void OnSwitchToggled(object sender, ToggledEventArgs args)
        {
            SetTriggerTime();
            SetTriggerTimeEnd();
        }
        void SetTriggerTime()
        {
            if (_switch.IsToggled)
            {
                _triggerTime = DateTime.Today + _timePicker.Time;
                if (_triggerTime < DateTime.Now)
                {
                    _triggerTime += TimeSpan.FromMinutes(_repeatTime);
                }
            }
        }
        void SetTriggerTimeEnd()
        {
            if (_switch.IsToggled)
            {
                _triggerTimeEnd = DateTime.Today + _timePickerEnd.Time;
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

        private void half_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            _repeatTime = 30;
        }
        private void one_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            _repeatTime = 60;
        }
        private void onehalf_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            _repeatTime = 90;
        }
        private void two_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            _repeatTime = 120;
        }
        private void twohalf_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            _repeatTime = 150;
        }
        private void three_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            _repeatTime = 180;
        }
        private void threehalf_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            _repeatTime = 210;
        }
        private void four_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            _repeatTime = 240;
        }
    }
}