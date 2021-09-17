using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using HavaDurumu.Model;
using Windows.ApplicationModel.Core;


namespace HavaDurumu
{
    public sealed partial class Page4 : Page
    {
        
        DispatcherTimer Timer = new DispatcherTimer();
        public Page4()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Required;
            this.ViewModel = new City4ViewModel();
            DataContext = this;

            Timer.Tick += Timer_Tick;
            Timer.Start();

            var timer = new DispatcherTimer() { Interval = TimeSpan.FromSeconds(15) };
            timer.Start();
            timer.Tick += (s, e) =>
            {
                Frame.Navigate(typeof(MainPage));
                timer.Stop();
            };
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {

        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

        }

        public City4ViewModel ViewModel { get; set; }
        private void Timer_Tick(object sender, object e)
        {
            Time.Text = DateTime.Now.ToString("HH:mm:ss ");
        }

    }
}
