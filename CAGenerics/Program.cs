/// References channels for explain 
/// https://www.youtube.com/watch?v=xE6bS6EfKAc
/// 

#region Generic Method
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
