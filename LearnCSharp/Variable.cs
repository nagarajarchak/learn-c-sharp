using System;

namespace LearnCSharp
{
	public class Variable
	{
		public Variable()
		{
			string str = "This is a string!";
			Console.WriteLine(str);

			int num = 10;
            Console.WriteLine(num);

            char character = 'a';
            Console.WriteLine(character);

            double floatNumber = 10.56;
            Console.WriteLine(floatNumber);

            bool boolean = true;
            Console.WriteLine(boolean);

            const int constantNum = 30;
            Console.WriteLine("Constant number: " + constantNum);

            string str1 = "str1 ";
            string str2 = "str2";
            string concatStr = str1 + str2;
            Console.WriteLine(concatStr);

            int a = 10, b = 20, c = 30;
            Console.WriteLine(a + b + c);

            int x, y, z;
            x = y = z = 40;
            Console.WriteLine(x + y + z);
        }
  	}
}

