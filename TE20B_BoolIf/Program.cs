using System;

// string name = "6";
// Console.WriteLine(name + name);

Console.WriteLine("Vad heter du?");
string name = Console.ReadLine();

name = name.ToLower();

//if (name == "micke" || name == "Micke" || name == "mIckE")

if (name == "micke")
{
  Console.WriteLine("Welcome!");
}
else if (name == "albert")
{
  Console.WriteLine("Almost as welcome but not quite");
}
else
{
  Console.WriteLine("NO");
}

Console.ReadLine();
