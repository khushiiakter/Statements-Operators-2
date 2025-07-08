// Step 1: Create instance of MyCollection<string>
using Generics;

var collection = new MyCollection<string>();

// Step 2: Add some items
collection.AddItem("Apple");
collection.AddItem("Banana");
collection.AddItem("Mango");
collection.AddItem("Mango");
//collection._items.Add("Orange");
//foreach (var item in collection._items)
//{
//    Console.WriteLine(item);
//}
// Step 3: Use GetItems method to return as List<string>
List<string> itemsAsList = collection.GetItems<List<string>>();
Console.WriteLine("Returned as List:");
foreach (var item in itemsAsList)
{
    Console.WriteLine(item);
}

// Step 4: Use GetItems method to return as HashSet<string>
HashSet<string> itemsAsSet = collection.GetItems<HashSet<string>>();
Console.WriteLine("Returned as HashSet:");
foreach (var item in itemsAsSet)
{
    Console.WriteLine(item);
}