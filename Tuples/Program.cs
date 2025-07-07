
using Tuples;

Membership membership = new Membership();
//(AccountCreationStatus status, User user) result = membership.CreateUser("khuhsi", "1234");
var result = membership.CreateUser("khuhsi", 14568);
//Console.WriteLine(result);


Console.WriteLine(result.status);
Console.WriteLine(result.user.Username);
Console.WriteLine(result.user.Password);

Membership membership1 = new Membership();
var result1 = membership1.CreateUser("hena", 1234444);


Console.WriteLine($"Status: {result1.status}; UserName: {result1.user.Username}; Password: {result1.user.Password}");

//Console.WriteLine(membership.CreateUser("khuhsi", "1234"));


//(double x, int y) tupleExample = (5.3, 5);

//nullable type
string name = null;

//int age = null; showing error;

int? age = null; // now i can set the null.
Console.WriteLine(age.HasValue);
if (age.HasValue)
{

    Console.WriteLine($"age is {age.Value}");
}
else
{
    Console.WriteLine($"age is null");

}


// lamda method --> arrow function er moto. ak line e return hole.

int sum (int a, int b) => a + b;