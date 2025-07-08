
List<string> names = new List<string> { "Arif", "Babu", "Rafiq", "Karim", "Rana", "Khushi", "Khushi", "Kokila" };


List<string> names2 = ["Arif", "Babu", "Rafiq", "Karim", "Rana"];// Using C# 12 list syntax - Collection expressions 


// linq method syntax
//var kNames = names.Where(name => name.StartsWith("K"));
var kNames = names.Select(name => name.ToUpper());

var employees = Enumerable.Range(1, 10)
    .Select(i => new { Id = i, Name = $"Employee {i}" });

var abc = employees.Where(emp => emp.Id % 2 == 0)
        .OrderByDescending(emp => emp.Id)
         .Select(emp => emp.Name)
         .ToList();

//var kNames = names.Select(name => name.ToUpper()).Where(name => name.StartsWith("K"));

//var rNames = names.Where(name => name.StartsWith("R"));

var sortedAsc = names.OrderBy(name => name);
// Descending sort
var sortedDesc = names.OrderByDescending(name => name);


int total = names.Count(); // Total
int countK = names.Count(name => name.StartsWith("K")); // Starts with K

string first = names.First();  // "Arif"
var firstK = names.FirstOrDefault(name => name.StartsWith("K"));  // "Karim"
string last = names.Last();  // "Kokila"


//Any – Check if any match
bool hasR = names.Any(name => name.StartsWith("R"));  // true

//All – Check if all match condition
bool allStartWithA = names.All(name => name.StartsWith("A"));  // false

//Console.WriteLine(allStartWithA);
//Console.WriteLine(hasR);

//Distinct – Remove duplicates
var distinctNames = names.Distinct();

Console.WriteLine(distinctNames);




foreach (var name in kNames)
{
    //Console.WriteLine(name);
}
