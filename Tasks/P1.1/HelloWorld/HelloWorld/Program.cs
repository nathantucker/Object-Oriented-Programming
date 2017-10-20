using System;

namespace HelloWorld
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Message[] messages = new Message[4];
			string name;

			string nathan = "nathan";
			string john = "john";
			string fiona = "fiona";

			messages[0] = new Message("Evening, good sir!");
			messages[1] = new Message("How do you do?");
			messages[2] = new Message("Enjoy your afternoon.");
			messages[3] = new Message("Get out of my sight.");

			Console.WriteLine("Enter name: ");
			name = Console.ReadLine();

			if (name.ToLower().Equals(nathan))
			{
				messages[0].Print();
			}
			else if (name.ToLower().Equals(john))
			{
				messages[1].Print();
			}
			else if (name.ToLower().Equals(fiona))
			{
				messages[2].Print();
			}
			else 
			{
				messages[3].Print();
			}

			Console.ReadLine();
		}
	}
}
