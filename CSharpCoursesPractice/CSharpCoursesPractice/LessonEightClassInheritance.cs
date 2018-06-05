using System;


namespace CSharpCoursesPractice
{
    public class LessonEightClassInheritance
    {
        public static void Main()
        {
            //All tasks appear here:
            //Užduotys paleidžiamos čia:

            TestingTernaryOperator();


            Console.ReadKey();
		}



        public static void TestingTernaryOperator()
        {
            //TASK: Test ternary operator
            //UŽDUOTIS: Ištestuoti ternary operatorių

            int number;
            Console.WriteLine("Enter int number:");
            string input = Console.ReadLine();
            bool isNumber = int.TryParse(input, out number);

            //Basic If sentence
            if (!isNumber)
            {
                Console.WriteLine("That's not a number!");
            }
            else
            {
                Console.WriteLine("Nice number, duuuude!");
            }

            //TernaryOperator
            Console.WriteLine("Enter another in number:");
            input = Console.ReadLine();
            isNumber = int.TryParse(input, out number);

            Console.WriteLine(!isNumber ? "What? Not an int number." : "Bro, great!");

            number = number > 15 ? number * 4 : number = 0;

            Console.WriteLine("New number : " + number);

        }
    }
}
