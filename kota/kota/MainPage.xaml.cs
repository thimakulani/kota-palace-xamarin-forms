using kota.Models;
using Plugin.CloudFirestore;
using Plugin.FirebaseAuth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace kota
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


            var user = CrossFirebaseAuth
                .Current
                .Instance
                .CurrentUser;
            CrossCloudFirestore
                .Current
                .Instance
                .Collection("Customers")
                .Document(user.Uid)
                .AddSnapshotListener((value, error) =>
                {
                    if (value.Exists)
                    {
                        var customer = value.ToObject<Customer>();
                        lblNames.Text = $"HI, {customer.Name}".ToUpper();
                    }

                });
        }
       
    }
}
