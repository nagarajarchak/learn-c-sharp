﻿using System;

namespace LearnCSharp
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("\n-- Output --\n");
            Output output = new Output();

            Console.WriteLine("\n-- Variable --\n");
            Variable variable = new Variable();

            Console.WriteLine("\n-- Type Casting --\n");
            TypeCasting typeCasting = new TypeCasting();

            Console.WriteLine("\n-- Conditional Statements --\n");
            Condition condition = new Condition();

            Console.WriteLine("\n-- Loops --\n");
            Loop loop = new Loop();

            Console.WriteLine("\n-- Switch Case --\n");
            Switch switchCase = new Switch();
        }
    }
}