Console.WriteLine("What is the input string?");
string input = Console.ReadLine() ?? "";
Console.WriteLine("The length of {0} is: {1}", input, input.Length);
