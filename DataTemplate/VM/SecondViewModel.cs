using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace DataTemplate.VM
{
    public class SecondViewModel : INotifyPropertyChanged 
    {

        private bool _isRefreshing;
 

        public bool IsRefreshing
        {
            get => _isRefreshing;
            set => OnPropertyChanged("IsRefreshing");
        }

        public ICommand LoadChargesAndPaymentsCommand { get; set; }
        public ObservableCollection<PaymentsAndDevicesModel> PaymentsAndDevices { get; set; }
        public ICommand OnRefreshCommand { get; set; }
        public SecondViewModel()
        {
            OnRefreshCommand = new Command(async()=> await RefreshCommand());
            PaymentsAndDevices = new ObservableCollection<PaymentsAndDevicesModel>();
            LoadChargesAndPaymentsCommand = new Command(async () => await RefreshCommand());
            LoadChargesAndPaymentsCommand.Execute(null);
        }

        private async Task RefreshCommand()
        {
            IsRefreshing = true;
            await Task.Delay(TimeSpan.FromSeconds(.5));
            PaymentsAndDevices.Clear();
            Random rdn = new Random();
            for (int i = 0; i < 2; i++)
            {
              
                PaymentsAndDevices.Add(new PaymentsAndDevicesModel() {
                    Number = rdn.Next().ToString(),
                    Name = "I'm a payment",
                    Type = "Payment"
                });
            }
            for (int i = 0; i < 1; i++)
            {

                PaymentsAndDevices.Add(new PaymentsAndDevicesModel()
                {
                    Number = rdn.Next().ToString(),
                    Name = "I'm a device",
                    Type = "Device"
                });
            }
            IsRefreshing = false;
        }

        public void LoadPaymentsAndDevices()
        {
            PaymentsAndDevicesModel p1 = new PaymentsAndDevicesModel() { Name = "I'm a PaymentsAndDevicesModel" };
            PaymentsAndDevicesModel p2 = new PaymentsAndDevicesModel() { Name = "I'm a PaymentsAndDevicesModel", Number = "12345" };

            PaymentsAndDevices.Add(p1);
            PaymentsAndDevices.Add(p2);

        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
