using System;

namespace Cellphone {
    class Program {
        static void Main(string[] args) {
            var cp1 = new Cellphone {
                PhoneNumber = "513-331-1710",
                ServiceProvider = "T-Mobile",
                OperatingSystem = "iOS",
                Capacity = 128,
                Model = "iPhone X"
            };
            var cp2 = new Cellphone {
                PhoneNumber = "513-410-5301",
                ServiceProvider = "T-Mobile",
                OperatingSystem = "Android",
                Capacity = 64,
                Model = "Samsung"
            };
            var cellPhones = new Cellphone[] { cp1, cp2 };

            foreach( var cp in cellPhones) {
                Console.WriteLine($"phone number is {cp.PhoneNumber}");
            }
        }
    }
    
}
