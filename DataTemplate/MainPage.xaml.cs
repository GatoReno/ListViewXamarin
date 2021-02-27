using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTemplate.Models;
using DataTemplate.VM;
using Xamarin.Forms;

namespace DataTemplate
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new SecondViewModel();
        }

        //async void ListView_ItemTapped(System.Object sender, Xamarin.Forms.ItemTappedEventArgs e)
        //{
        //    switch (e.Item)
        //    {
        //        case (Payments):
        //            var p = (Payments)e.Item;
        //            await DisplayAlert("Payment", $"{p.Name}", "ok");
        //            break;
        //        case (Devices):
        //            var d = (Devices)e.Item;
        //            await DisplayAlert("Device", $"{d.Name} / {d.Number}", "ok");
        //            break;
        //        default:
        //            break;
        //    }
        //}
    }
}