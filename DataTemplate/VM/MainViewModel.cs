using System;
using System.Collections.ObjectModel;
using DataTemplate.Models;

namespace DataTemplate.VM
{
    public class MainViewModel
    {
        public ObservableCollection<object> PaymentsAndDevices { get; set; }

        public MainViewModel()
        {
            PaymentsAndDevices = new ObservableCollection<object>();
            LoadPaymentsAndDevices();
        }

        public void LoadPaymentsAndDevices()
        {
            Payments p1 = new Payments() { Name = "I'm a payment" };
            Devices p2 = new Devices() { Name = "I'm a device", Number = "12345"};

            PaymentsAndDevices.Add(p1);
            PaymentsAndDevices.Add(p2);

        }
    }
}
