using Android.OS;
using System;
using System.Collections.Generic;
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
        DateTime _triggerTimeStart;
        DateTime _triggerTimeEnd;
        void sendNotify()
        {
            void SendNotification(object sender, EventArgs e, int periodTimeSpan)
            {
                DependencyService.Get<INotification>().CreateNotification("Drink Water", "It`s time to drink water!🙂");

                 Task.Delay(new TimeSpan.(periodTimeSpan)).ContinueWith(o => {sendNotify(); }); //powtarza funkcję co periodTimeSpan czasu 
            }
        }

        public void SetInterval()
        {
           
        }

        public SetPage()
        {
            InitializeComponent();
            Device.StartTimer(TimeSpan.FromSeconds(1) );

            var startTimeSpan = TimePicker_Start;
            var endTimeSpan = TimePicker_End;
            var periodTimeSpan;

            //var timer = new System.Threading.Timer((e) =>
            //{
            //    sendNotify();
            //}, null, startTimeSpan, periodTimeSpan);


            // TODO dodać do assembly permision dla wibracji
            // Use default vibration length
           // Vibration.Vibrate();

            // use specified time
            var duration = TimeSpan.FromSeconds(3);
            Vibration.Vibrate(duration);

        }

        void SetTriggerTime()
        {
          //  ustawienie startu jako triggertime
           
            _triggerTimeStart = DateTime.Today + TimePicker_Start.Time;
            _triggerTimeEnd= DateTime.Today + TimePicker_Start.Time;
            if (_triggerTimeStart < DateTime.Now 
                && _triggerTimeEnd <= DateTime.Now)
               _triggerTimeStart += TimeSpan.FromDays(1);//tu ma powtórzyć co dobę NIBY
       
                
                //zakończ działanie i czekaj znów na odpowiednia godzinę

                //ustawiene końowki jako endpoint

        }

        }
}
