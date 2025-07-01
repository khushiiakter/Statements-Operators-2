using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Car:Vehicles
    {
        public string brand;

        public void Sound()
        {
            Console.WriteLine($"{brand} sounds beep beep");
        }
        public Car(String _speed, string _brand)
        {
            speed = _speed;
            brand = _brand;
            Console.WriteLine($"{speed} is the fastest.");
        }
    }
}
