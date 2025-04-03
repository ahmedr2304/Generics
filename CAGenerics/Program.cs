
#region Generic Method
using CAGenerics;

/// References channels for explain 
/// https://www.youtube.com/watch?v=xE6bS6EfKAc
/// 
Print(1); // pass int as paramter
Print("Ahmed"); // pass string as paramter
Print(new {Fname ="Ahmed",LName="Ramadan"}); // Anonymous Object 
/// Generic Method
static void Print<T>(T Value)
{
    Console.WriteLine("******** Generic Method ***********");
    Console.WriteLine($"Type Paramter : {typeof(T)}");
    Console.WriteLine($"Value : {Value}");
    Console.WriteLine("******** End Generic Method ***********");
    Console.WriteLine("\n\n");
}
#endregion

#region GenericClas
Console.WriteLine("******** Generic Class ***********");
// this array is number array
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("~~~~~~~Numbers Array~~~~~~~~~~");
Console.ForegroundColor = ConsoleColor.Gray;
var numbers = new GenericClass<int>();
numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
numbers.Add(4);
numbers.DisplayList();
Console.WriteLine();
Console.WriteLine($"Array List is :{numbers.Count} items");
Console.WriteLine($"Empty Status :{numbers.IsEmpty} ");
Console.WriteLine("~~~~~~~After Remove Item~~~~~~~~~~");
Console.ForegroundColor = ConsoleColor.Red;
numbers.RemoveAt(3);

numbers.DisplayList();
Console.WriteLine();

// this array is number array
Console.ForegroundColor = ConsoleColor.DarkYellow;

Console.WriteLine("~~~~~~~String Array~~~~~~~~~~");
Console.ForegroundColor = ConsoleColor.Gray;

var strings = new GenericClass<string>();
strings.Add("Ahmed");
strings.Add("Nora");
strings.Add("Jowiraia");
strings.Add("Judy");
strings.Add("Najawa");
strings.DisplayList();
Console.WriteLine();
Console.WriteLine($"Array List is :{strings.Count} items");
Console.WriteLine($"Empty Status :{strings.IsEmpty} ");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("~~~~~~~After Remove Item~~~~~~~~~~");

strings.RemoveAt(3);

strings.DisplayList();
Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine();

// this array is Person array
Console.ForegroundColor = ConsoleColor.Blue;

Console.WriteLine("~~~~~~~Person Array~~~~~~~~~~");
Console.ForegroundColor = ConsoleColor.Gray;

var People = new GenericClass<Person>();
People.Add(new Person{ Fname="Ahmed",Lname="Ramadan"});
People.Add(new Person { Fname = "Nora", Lname = "Shahin" });
People.Add(new Person { Fname = "Jowiraia", Lname = "Ahmed" });
People.Add(new Person { Fname = "Judy", Lname = "Ahmed" });
People.Add(new Person { Fname = "Najawa", Lname = "Ahmed" });

People.DisplayList();
Console.WriteLine();
Console.WriteLine($"Array List is :{People.Count} items");
Console.WriteLine($"Empty Status :{People.IsEmpty} ");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("~~~~~~~After Remove Item~~~~~~~~~~");

People.RemoveAt(3);

People.DisplayList();
Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine();


Console.WriteLine("******** End Generic Class ***********");
Console.WriteLine("\n\n");
#endregion
