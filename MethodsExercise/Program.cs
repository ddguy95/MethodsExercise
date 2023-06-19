using Microsoft.VisualBasic;
using System.Drawing;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // ---------------------------------------Exercise 1-------------------------------------------------------
            //Name: Derrick
            //Favorite Color: Navy blue
            //Favorite Animal: Birds
            //Favorite Band: New Edition



            Console.WriteLine("What is your name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hi, {userName} What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"{color} is a great color. It's so relaxing.  What's your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine($"Verrry Nice!  Now, what band are you fond of?");
            var band = Console.ReadLine();

            Console.WriteLine($"Thanks, {userName}! Here is your profile...");
            Console.WriteLine("--------------------------------------------------------------");
            
            Console.WriteLine($"Name: {userName}");
            Console.WriteLine($"Favorite Color: {color}");
            Console.WriteLine($"Favorite Animal: {animal}");
            Console.WriteLine($"Favorite Band: {band}");
            


        }
    }
}
