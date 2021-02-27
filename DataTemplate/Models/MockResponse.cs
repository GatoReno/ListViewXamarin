using System;
using System.Collections.Generic;

namespace DataTemplate.Models
{
    public class MockResponse
    {
        public List<Payments> Payments { get; set; }
        public List<Devices> Devices { get; set; }
    }

    public class Devices
    {
        public string Name { get; set; }
        public string Number { get; set; }
    }

    public class Payments
    {
        public string Name { get; set; }
    }
}
