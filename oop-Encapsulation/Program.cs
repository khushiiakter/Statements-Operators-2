using System;

public class Student
{
    // getter setter
    private string name;
    private int marks;

    public string _name
    {
        get { return name; }
        set { name = value; }
    }


   
    public int _marks
    {
        get { return marks; }
        set
        {
            if (value >= 0 && value <= 100)
            {
                marks = value;
            }
            else
            {
                Console.WriteLine("the marks is invalid");
            }
        }

    }
    public Student(string n, int m)
    {
        _name = n;
        _marks = m;
    }

    public void printDetails()
    {
        Console.WriteLine($"Name: {_name}, Marks: {_marks}");
    }

}



class Program
{
    public static void Main(string[] args)
    {
        Student student1 = new Student("khushi", 24);
        //Console.WriteLine($"Name: {student1._name}, Marks: {student1._marks}");
        student1.printDetails();

        Student stu2 = new Student("resma", 97);
        stu2.printDetails();
    }
}