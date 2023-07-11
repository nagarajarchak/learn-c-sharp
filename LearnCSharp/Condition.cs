using System;
namespace LearnCSharp
{
	public class Condition
	{
		public Condition()
		{
            if (20 > 18)
            {
                Console.WriteLine("20 is greater than 18");
            }

            int time = 15;
            string result = (time < 18) ? "Passed" : "Failed";
            Console.WriteLine(result);

        }
	}
}

