using kota.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace kota
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            if(Plugin.FirebaseAuth.CrossFirebaseAuth.Current.Instance.CurrentUser != null)
            {
                MainPage = new MainPage();
              
            }
            else
            {
                MainPage = new Login();
            }
            Plugin.FirebaseAuth.CrossFirebaseAuth.Current.Instance.AuthState += Instance_AuthState;
        }

        private void Instance_AuthState(object sender, Plugin.FirebaseAuth.AuthStateEventArgs e)
        {
            if(e.Auth.CurrentUser != null)
            {
                MainPage = new MainPage();
            }
            else
            {
                MainPage = new Login();
            }
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
