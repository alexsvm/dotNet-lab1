using System;

class MyApp
{
	static void Main(string[] args)
	{
		int count = args.Length;
		if (count == 0) {
			Console.WriteLine("This program requires a parameter in command line!");
		} else {
			Console.WriteLine("Hello, " + args[0] + "!");
		}
		Console.ReadLine();
	}
		
};
