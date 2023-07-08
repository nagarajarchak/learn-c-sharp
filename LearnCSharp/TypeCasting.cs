using System;

namespace LearnCSharp
{
	public class TypeCasting
	{
		public TypeCasting()
		{
            // Implicit type conversion
            int intNumberOne = 10;
            double doubleNumberOne = intNumberOne;
            Console.WriteLine(doubleNumberOne);

            // Explicit type conversion
            double doubleNumberTwo = 10.56;
            int intNumber = (int)doubleNumberTwo;
            Console.WriteLine(intNumber);
        }
	}
}

