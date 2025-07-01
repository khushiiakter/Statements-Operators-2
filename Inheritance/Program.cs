using Inheritance;
using System;

class Program3
{
    public static void Main(string[] args)
    {
        Car car1 = new Car("120 km/h", "Toyota");

        car1.Start();
        car1.Sound();
        car1.Stop();
    }
}