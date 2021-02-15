using System;
using System.Collections.Generic;
using System.Text;

namespace Cellphone {
    class Cellphone {
        public string PhoneNumber { get; set; }
        public string ServiceProvider { get; set; }
        public string OperatingSystem { get; set; }
        public bool Active { get; set; } = true;
        public int Capacity { get; set; }
        public string Model { get; set; }
    }
}
