using System;

namespace Giraffe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string characterName = "Tom";
            int characterAge = 25; 

            Console.WriteLine($"There once was a man named {characterName}");
            Console.WriteLine($"He was {characterAge} years old");

            characterName = "Mike";                    //Ability to change names mid story
            Console.WriteLine($"He really liked the name {characterName}");
            Console.WriteLine($"But he didn't like being {characterAge}");


            Console.ReadLine();
        }
    }
}
