using System;

class Person
{
   public string name;
   public int age;
}


class Test
{
    public static void Main(string[] args)
    {
        //switch 

        //Console.Write("Enter a digit:");
        //int digit = Convert.ToInt32(Console.ReadLine());

        //switch (digit)
        //{

        //    case 0:
        //    Console.WriteLine("zero");
        //        break;
        //    case 1:
        //        Console.WriteLine("one");
        //        break;
        //    case 2:
        //        Console.WriteLine("two");
        //        break;
        //    default:
        //        Console.WriteLine("not a digit");
        //        break;
        //}

        //object number = "ata text";

        //string result = number switch
        //{
        //    int => "integer",
        //    string => "string or text",
        //    double => "double",
        //    _ => "unknown",
        //};

        //Console.WriteLine($"{result}");

        //switch with when operator

        //Console.Write("Enter a number between 1 to 10: ");
        //int number = Convert.ToInt32(Console.ReadLine());

        //switch (number)
        //{
        //    case int num when num % 2 == 0:
        //        Console.WriteLine($"{num} is a even number");
        //        break;

        //    case int num when num % 2 != 0:
        //        Console.WriteLine($"{num} is a odd number");
        //        break;

        //    default:
        //        Console.WriteLine($"THis is not a number.");
        //        break;
        //}


        // lists

        /**List<T> হচ্ছে C# এর একটা Generic Collection ক্লাস যা ব্যবহার করে তুমি অনেকগুলো ডাটা একসাথে রাখতে পারো, ঠিক অ্যারে (array) এর মতো—but আরও সুবিধাজনক।

🔹 এখানে T মানে হচ্ছে Type — যেমন List<int>, List<string> ইত্যাদি।
🔹 List-এর সাইজ ডাইনামিক — মানে চাইলে তুমি যেকোনো সময় ডাটা যোগ করতে বা বাদ দিতে পারো।

**/
        //List<string> names = new List<string>();


        //names.Add("khushi");
        //names.Add("aresma");
        //names.Add("cfdjfkjf");
        ////names.Remove("khushi");
        ////names.Sort();
        //foreach (string name in names)
        //{
        //    Console.WriteLine(name);
        //}
        //Console.WriteLine(names[0]);
        //Console.WriteLine(names.Count);

        //var ba int use kora jabe - because indexof returns a int number;
        //int index = names.IndexOf("aresma");
        //Console.WriteLine(index);

        //if (index == -1)
        //{
        //    Console.WriteLine("name not found");
        //}
        //else
        //{
        //    Console.WriteLine($"name is found in index number {index}");
        //}



        //febonacchi number

        //List<int> febonacchiNumber = new List<int> { 1, 2 };

        //while (febonacchiNumber.Count < 20 )
        //{
        //    int lastPrevious = febonacchiNumber[febonacchiNumber.Count - 1]; // last elemnt er index nubmer , last element pabe .
        //    int previous = febonacchiNumber[febonacchiNumber.Count - 2]; // last er ager ta 


        //    febonacchiNumber.Add(lastPrevious + previous);

           
        //}
        //foreach (int num in febonacchiNumber)
        //{
        //    Console.WriteLine(num);
        //}


        Person person1 = new Person();
        person1.name = "khushi";
        person1.age = 22;

        Person person2 = new Person();
        person2.name = "reshma";
        person2.age = 23;
        
        Console.WriteLine("Person 1:");
        Console.WriteLine($"Name: {person1.name}, Age: {person1.age}");


    }
}