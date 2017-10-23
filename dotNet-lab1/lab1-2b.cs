using System;

class MyApp
{
	static void Main(string[] args)
	{
		try {
			Console.WriteLine("Hello, " + args[0] + "!");
		}
		catch {
			Console.WriteLine("This program requires a parameter in command line!");
		}
		Console.ReadLine();
	}
		
};
