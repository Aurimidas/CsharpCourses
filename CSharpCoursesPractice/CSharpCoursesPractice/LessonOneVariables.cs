using System;
namespace CSharpCoursesPractice
{
    public class LessonOneVariables
    {
        public static void Main()
        {
            //All tasks appear here
            //Užduotys paleidžiamos čia

            //EnterInfoAboutYourself();
            //SwapTwoNumbers();
            //TestingVariables();

            Console.ReadKey();
        }

        public static void EnterInfoAboutYourself ()
        {
            //TASK: Write a program which asks you to enter your NAME, SURNAME, AGE. Display to screen at least 2 different options
            //UŽDUOTIS: Parašyti programą, kuri paprašo įvesti jūsų VARDĄ, PAVARDĘ, AMŽIŲ. Rodyti ekrane bent 2 būdais

            Console.WriteLine("Enter Your name, please:");
            string name = Console.ReadLine(); //nuskaitomas įvedimas
            Console.WriteLine("Enter Your surname, please:");
            string surname = Console.ReadLine();
            Console.WriteLine("How old are You?");
            int age = Convert.ToInt32(Console.ReadLine()); //nuskaitymas yra string tipo, todėl nuskaitymą konvertuojam į int

            //Option how to check if input is a number. (Comment section)
            //Variantas kaip galima patikrinti ar įvestas skaičius. (Užkomentuotas)
            /*string input = Console.ReadLine();
            bool isNumber = int.TryParse(input, out age);*/

            //Išvedimas į ekraną 1.0
            Console.WriteLine("Your name is " + name + " and surname is " + surname + ". You're " + age + " years old.");
            //Išvedimas 1.1
            Console.WriteLine("Your name is {0} and surname is {1}. You're {2} years old.", name, surname, age);
            //Išvedimas 2.0
            Console.WriteLine($"Your name is {name} and surname is {surname}. You're {age} years old.");

        }

        public static void SwapTwoNumbers ()
        {
            //TASK: Swap 2 int numbers in places
            //UŽDUOTIS: Sukeisti 2 int skaičius vietomis

            Console.WriteLine("Enter first int number:");
            int numb1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second int number:");
            int numb2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You have entered two int.\nNumber1: {numb1}\nNumber2: {numb2}");

            //Susikuriam trečią int skaičių, kuris padės sukeisti vietomis
            int swapNumb = 0;
            swapNumb = numb1;
            numb1 = numb2;
            numb2 = swapNumb;

            Console.WriteLine($"We swapped your numbers! From now on.\nNumber1: {numb1}\nNumber2: {numb2}");

            //Swapping two numbers without third int number
            //Skaičių keitimas be trečio int skaičiaus

            numb1 = numb1 + numb2;
            numb2 = numb1 - numb2;
            numb1 = numb1 - numb2;

            Console.WriteLine($"We swapped your numbers again! From now on.\nNumber1: {numb1}\nNumber2: {numb2}");
        }

        public static void TestingVariables ()
        {
            //TASK: Test some functions
            //UŽDUOTIS: Prasitestuoti kintamųjų funkcijas

            float number = 5;
            int number2 = 10;

            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}", number, number.GetType(), sizeof(float), number.ToString(), float.MaxValue, float.MinValue);
            Console.WriteLine("________________________________");
            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}", number2, number2.GetType(), sizeof(int), number2.ToString(), int.MaxValue, int.MinValue);
            Console.WriteLine("________________________________");
            Console.WriteLine("Test: " + (5/2));
            Console.WriteLine("Test2: " + ((float)5/2));
            Console.WriteLine("Test3: " + (5f/2));
        }
    }
}
