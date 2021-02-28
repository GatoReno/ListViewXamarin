using System;
using DataTemplate.VM;
using Xamarin.Forms;

namespace DataTemplate.TemplateSelector
{
    public class PaymentTypeTemplateSelector : DataTemplateSelector
    {
       public Xamarin.Forms.DataTemplate PaymentTemplate { get; set; }
       public Xamarin.Forms.DataTemplate DeviceTemplate { get; set; }
 
        protected override Xamarin.Forms.DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var pay = (PaymentsAndDevicesModel)item;
            switch (pay.Type)
            {
                case "Device":
                    return DeviceTemplate;
                default:
                    return PaymentTemplate;
            }
        }
    }
}
