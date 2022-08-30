using System;

class Program
{
	static void Main(string[] args)
	{
		string str = "Holberton School";
		Console.WriteLine("{0}{0}{0}\n{0}", str, str, str, str.Substring(0,9));
        }
}
