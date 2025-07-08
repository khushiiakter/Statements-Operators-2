using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{

    public static class StringExtensions
    {
        public static string ReverseString(this string str)
        {
            char[] array = str.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }

        public static void ShowSpeed(this string abc, int speed)
        {
            Console.WriteLine($"The speed is {speed}");
        }
    }


    class Vehicles
    {
        public string speed;

        public void Start()
        {
            Console.WriteLine("vehicle started.");
        }

        public void Stop() {
            Console.WriteLine("vehicles stop");

            var abc = "abc is a string";

            abc.ShowSpeed(100);
            abc.ReverseString();

        }

        
    }


}
