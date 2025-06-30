using System;

class Person
{
    public string name;
    public int age;

    //akhane function ba method declare kore value gulo nibo

    public void GetValue(string n, int a)
    {
        name = n;
        age = a;
    }


    //akhon constructor banabo. but constructor mehtod ar class name soman rakhte hobe.

    public Person(){
        name = "hena";
        age = 1000;
    }
    public Person(string n, int a) { 
        name = n;
        age = a;
    }
    // but akhon chai amra parameter hisebe value pass korbo...
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
    }
}


class Test
{
    public static void Main(string[] args)
    {


        Person person1 = new Person("Khushi as parameter", 22);
        //person1.name = "khushi";
        //person1.age = 22;
        //person1.GetValue("khushi", 22);
        Console.WriteLine("Person 1:");
        person1.DisplayInfo();
        
      
        Person person2 = new Person();

        
        //person2.name = "reshma";
        //person2.age = 54;
        //person2.GetValue("veer", 25); constructors use kore object create korar somoy i value ba default man set korte chai.

        Console.WriteLine("PErson2 :");
        person2.DisplayInfo();


        Person person3 = new Person("akter", 4);
        person3.DisplayInfo();

        //Console.WriteLine($"Name: {person1.name}, Age: {person1.age}");

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



    }
}