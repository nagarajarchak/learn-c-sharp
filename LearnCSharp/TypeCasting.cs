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
            int intNumberTwo = (int) doubleNumberTwo;
            Console.WriteLine(intNumberTwo);

            // Type conversion methods
            int intNumberThree = 15;
            double doubleNumberThree = Convert.ToDouble(intNumberThree);
            string numStr = Convert.ToString(intNumberThree);
            Console.WriteLine(doubleNumberThree);
            Console.WriteLine(numStr);
        }
	}
}

