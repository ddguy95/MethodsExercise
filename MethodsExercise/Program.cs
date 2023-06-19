using Microsoft.VisualBasic;
using System.ComponentModel;
using System.Drawing;

namespace MethodsExercise
{
    public class Program
    {
        public static int Sum(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }

        public static int Multiply(int num1, int num2)
        {
            int answer = num1 * num2;
            return answer;
        }
        public static int Subtract(int num1, int num2)
        {
            int answer = num1 - num2;
            return answer;
        }
        public static int Divide(int num1 , int num2)
        {
            int answer = num1 / num2;
            return answer;
        }



        /*-----------------------------------------------*/
        static void Main(string[] args)
        {

            var answer1 = Sum(2, 6); //calling the method
            Console.WriteLine(answer1);

            int answer2 = Multiply(5, 10);
            Console.WriteLine(answer2);

            var answer3 = Subtract(75, 25);
            Console.WriteLine(answer3);

            int answer4 = Divide(500, 10);
            Console.WriteLine(answer4);




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
