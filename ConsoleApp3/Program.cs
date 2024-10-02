// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter your age:");
string input = Console.ReadLine();

int age = int.Parse(input);

Console.WriteLine("Here's the result:");

if (age < 13)
{
    Console.WriteLine("Thou art but a child");
}
else if (age < 18)
{
    Console.WriteLine("You are a teenage dirtbag, baby");
}
else if (age < 25)
{
    Console.WriteLine("Young adult");
}
else
{
    Console.WriteLine("Adult");
}



Console.WriteLine("program fin");