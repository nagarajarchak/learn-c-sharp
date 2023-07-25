using System;

namespace LearnCSharp
{
	public class Switch
	{
		public Switch()
		{
			int day = 1;
			switch(day)
			{
				case 1:
					Console.WriteLine("Monday");
					break;
				case 2:
					Console.WriteLine("Tuesday");
					break;
				case 3:
					Console.WriteLine("Wednesday");
					break;
				default:
					Console.WriteLine("Invalid input");
					break;
			}
		}
	}
}

