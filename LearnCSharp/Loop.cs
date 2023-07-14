using System;

namespace LearnCSharp
{
	public class Loop
	{
		public Loop()
		{
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }

            int j = 0;
            do
            {
                Console.WriteLine(j);
                j++;
            }
            while (j < 5);

            string[] arr = { "str1", "str2", "str3", "str4" };
            foreach(string element in arr)
            {
                Console.WriteLine(element);
            }
        }
	}
}

