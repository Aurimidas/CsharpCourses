using System;
namespace CSharpCoursesPractice
{
    public class LessonThreeLoops
    {
        public static void Main ()
        {
            //All tasks appear here:
            //Užduotys paleidžiamos čia:

            //PrintEveryThirdNumber();
            //PrintNumbersBetweenTwoNumbers();
            //FindSumOfNumberSmallerThan1000();
            //EnterYourChoiceUsinhWhile();
            //AirplaneTickets();
            //FibonacciSequence();
            //GuessNumber();
            //Calculator();
            //SequenceFromTheHighestToTheLowest();
            //PalindromicNumber();
            //DecimalToBinary();

            Console.ReadKey();
		}

        public static void DecimalToBinary ()
        {
			Console.WriteLine("Enter int number");
			int decimalNumber = Convert.ToInt32(Console.ReadLine());
			int reminder;
			string result = " ";

			while (decimalNumber > 0)
			{
				reminder = decimalNumber % 2;
				decimalNumber /= 2;
				result = reminder.ToString() + result;
			}
			Console.WriteLine("Binary: {0}", result);
        }

        public static void PalindromicNumber ()
        {
			//TASK: Check if guven number is palindrome or not
			//UŽDUOTIS: Patikrinti ar skaičius yra polindromas ar ne

			//First example
			Console.WriteLine("Palindromic number. Ver 1.0");
            int reminder = 0;
            int newNumber = 0;
			Console.WriteLine("Enter int number and we will check if it's a palindomic number:");
            int number = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("The number you entered {0} backwards:", number);

			for (int i = number; i > 0; i /= 10) //Sudaromas naujas skaičius nuimant po skaičių iš galo
			{
				reminder = i % 10;
				Console.Write(reminder);

				newNumber = (newNumber * 10) + reminder;
				//Console.Write(newNumber);

			}

			if (newNumber == number) //Tikrinama ar naujas skaičius lygus įvestam skaičiui
			{
				Console.WriteLine($"\nCongrats! {number} is a palindromic number.");
			}
			else
			{
				Console.WriteLine("\n{0} is NOT a palindromic number.", number);
			}

			//Second example
			Console.WriteLine("Palindromic number. Ver 2.0");
			Console.WriteLine("Enter int number and we will check whether is palindrome or not:");
            int inputNumber = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("The number you entered {0}", inputNumber);
            int divider = 1;
            bool isPalindrome = true;

			while (inputNumber / divider >= 10) //Suskaičiuojama kiek skaičių sudaro divideris ir kiek skaičių sudaro įvestą skaičių
			{
				divider *= 10;
			}

			while (inputNumber != 0)
			{
                int frontNumber = inputNumber / divider; //išsaugomas priekinis numeris
                int lastNumber = inputNumber % 10; //išsaugomas galinis numeris

				if (frontNumber != lastNumber) //jeigu priekinis numeris nesutampa su galiniu baigiam programą
				{
					isPalindrome = false;
					break;
				}

				inputNumber = (inputNumber % divider) / 10; //nuimam priekinį ir galinį numerius

				divider = divider / 100; //pamažinam dividerį dviem skaičiais, kaip ir pagrindinis skaičius pamažinamas
			}

			if (isPalindrome == true)
			{
				Console.WriteLine("Congrats! It's a palindrome!");
			}
			else
			{
				Console.WriteLine("It's not a palindrome!");
			}
        }

        public static void SequenceFromTheHighestToTheLowest ()
        {
			//TASK: Write a calculator program
			//UŽDUOTIS: Parašyti skaičiuotuvo programą

            int number = new Random().Next(10, 100);
            for (int i = number; i > 0; i--)
			{
				Console.WriteLine(i);
			}
        }

        public static void Calculator ()
        {
            //TASK: Write a calculator program
            //UŽDUOTIS: Parašyti skaičiuotuvo programą

			//char input = ' ';
			ConsoleKeyInfo key;
			do
			{
				Console.WriteLine("Enter 2 int numbers.");
				Console.WriteLine("First number:");
                int number1 = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Second number:");
                int number2 = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Which operation do you want to use? (+ ; - ; * ; / ;)");
				Console.WriteLine("Enter 'n' or '0' to turn off the program.");
				//char input = Convert.ToChar(Console.ReadLine()); //Another option how to write a program
				//char input = Console.ReadKey().KeyChar; //Another option how to write a program
				key = Console.ReadKey();

                if (key.Key == ConsoleKey.Add)  //key.Key == ConsoleKey.Add //input == '+'
				{
					Addition(number1, number2);
				}
				else if (key.Key == ConsoleKey.Subtract)  //key.Key == ConsoleKey.Subtract //input == '-'
				{
					Subtraction(number1, number2);
				}
				else if (key.Key == ConsoleKey.Multiply)   //key.Key == ConsoleKey.Multiply //input == '*'
				{
					Multiplication(number1, number2);
				}
				else if (key.Key == ConsoleKey.Divide)   //key.Key == ConsoleKey.Divide //input == '/'
				{
					Division(number1, number2);
				}
                else if (key.Key == ConsoleKey.N || key.Key == ConsoleKey.D0 || key.Key == ConsoleKey.Escape) //input == 'n' || veiksmas == '0'
				{
					Console.WriteLine("\nBye bye!");
					break;
				}
				else
				{
					Console.WriteLine("\nWrong option. Try again.");
				}
			} while (key.Key != ConsoleKey.Escape); 
		}

        static void Addition(int number1, int number2)
		{
			Console.WriteLine($"\n{number1} + {number2} = {number1 + number2}");
		}
        static void Subtraction(int number1, int number2)
		{
			Console.WriteLine($"\n{number1} - {number2} = {number1 - number2}");
		}
        static void Multiplication(int number1, int number2)
		{
			Console.WriteLine($"\n{number1} * {number2} = {number1 * number2}");
		}
        static void Division(float number1, float number2)
		{
			if (number1 == 0)
			{
				Console.WriteLine("\nCan't divide!");
			}
			else
			{
				Console.WriteLine($"\n{number1} / {number2} = {number1 / number2}");
			}
		}

        public static void GuessNumber ()
        {
            //TASK: Computer randomise the golden number and user guesses it. Computer tells if guessed number is smaller or bigger. Playing till user wins
            //UŽDUOTIS: Kompiuteris sugalvoją skaičių, kurė bando atspėti vartotojas. Yra pasakoma ar spėtas skaičius didesnis ar mažesnis. Žaidžiama kol laimi vartotojas

            bool win = false;
            int goldenNumber = new Random().Next(0, 100);
            int guessCount = 0;

			while (!win)
			{
				Console.WriteLine("Guess number:");
                int guessNumber = Convert.ToInt32(Console.ReadLine());

				if (guessNumber < goldenNumber)
				{
					guessCount++;
					Console.WriteLine("Incorrect, golden number is bigger than you guess.");
				}
				else if (guessNumber > goldenNumber)
				{
					guessCount++;
					Console.WriteLine("Incorrect, golden number is smaller than you guess.");
				}
				else
				{
					guessCount++;
					Console.WriteLine("Congrats! You win!");
					Console.WriteLine($"You guessed it: {guessCount}");
					win = true;
				}
			}
        }

        public static void FibonacciSequence ()
        {
            //TASK: Fibonacci sequence.
            //UŽDUOTIS: Fibonačio eilutė. 

			Console.WriteLine("How many Fibonacci numbers do you want to see?");
			int fibNumber = Convert.ToInt32(Console.ReadLine());
			
            int number1 = 0;
            int number2 = 1;
            int number3 = 0;

			Console.WriteLine("Fibonacci sequence:");

            for (int i = 0; i < fibNumber; i++)
			{
				number3 = number1 + number2;
				number1 = number2;
				number2 = number3;
				Console.WriteLine(number3);
			}
        }

        public static void AirplaneTickets ()
        {
            //TASK: Use do while loop. We have 8 tickets, 4 of them are near the window. Ask user if he wants to sit near window or not. Stop asking then all 4 tickets near window are booked or all 8 tickets are sold.
            //UŽDUOTIS: Naudoti do while ciklą. Turim 8 lėktuvoo bilietus, 4 yra prie lango. Klausti vartotojo ar jis nori sėdėti prie lango ar ne. Nustoti klausinėti, kai visi 4 parduoti arba 8 atsakymai gauti.

            const int tickets = 8;
            const int nearWindow = 4;
            int soldTickets = 0;
            int soldNearWindow = 0;
            const string positive = "Yes";
            const string negative = "No";


			do
			{
                Console.WriteLine("Do you want to sit near window? (Yes/No)");
                string input = Console.ReadLine();

				if (input == positive)
				{
					soldTickets++;
					soldNearWindow++;
				}
				else if (input == negative)
				{
					soldTickets++;
				}
				else
				{
					Console.WriteLine("Wrong answer, please enter again.");
				}
			} while (soldTickets != tickets && soldNearWindow != nearWindow);
        }

        public static void EnterYourChoiceUsinhWhile ()
        {
			//TASK: user gets options and enters his choice till it's right. Use while loop
			//UŽDUOTIS: naudojant while ciklą duoti pasirinkimą vartotojui ir pabaigti programą tik tada, kai pasirinkimas teisingas

			Console.WriteLine("Choose something:");
			Console.WriteLine("1 - WOW! \n2 - Hello! \n3 - Bye!");
			int input = Convert.ToInt32(Console.ReadLine());

            while (input != 1 && input != 2 && input != 3) //(input < 1 && input > 3) TOKS GAL GERESNIS (This one is better)
			{
				Console.WriteLine("Incorrect! Enter again!");
				input = Convert.ToInt32(Console.ReadLine());
			}

			Console.WriteLine("Congrats!");
        }

        public static void FindSumOfNumberSmallerThan1000 ()
        {
			//TASK: find the sum of the numbers smaller than 1000 and which are divided by 5 and 3 without the remainder
			//UŽDUOTIS: rasti sumą skaičių mažesnių už 1000 ir kurie dalijasi iš 5 ir 3 be liekanos

            int sum = 0;
			for (int i = 0; i < 1000; i++)
			{
				if (i % 3 == 0 || i % 5 == 0)
				{
					sum += i;
				}
			}
			Console.WriteLine($"The sum of numbers which are divided by 5 and 3 without the reminder = {sum}");

			//ADDITIONAL: Add continue and break, but divide only by 5 and if the number gets bigger than 123 stop the loop
			//PAPILDYMAS: Panaudoti continue ir break, bet dalinti tik iš 5 ir jei skaičius tampa didesnis nei 123 sustabdyti ciklą

			int sum2 = 0;
			for (int i = 1; i < 1000; i++)
			{
				if (i % 5 == 0)
				{
					continue;
				}

				sum2 += i;

				if (i > 123)
				{
					break;
				}
			}
			Console.WriteLine(sum2);

			//ADITIONAL: Chage for loop, result must be the same
            //PAPILDYMAS: Pakeisti for ciklą, rezultatas turi išlikti toks pats

            int sum3 = 0;
            int number = 0;
			for (;;)
			{
				if (number >= 0 && number < 1000)
				{
					number++;

					if (number % 5 == 0)
					{
						continue;
					}

					sum3 += number;

					if (number > 123)
					{
						break;
					}
				}
			}
			Console.WriteLine(sum3);
		}

        public static void PrintEveryThirdNumber ()
        {
            //TASK: Use for loop. Print every third number from 0 to 20.
            //UŽDUOTIS: Naudojant for ciklą atspausdinti kas trečią skaičių nuo 0 iki 20. 

            for (int i = 0; i < 20; i+=3)
            {
                Console.WriteLine(i);
            }
        }

        public static void PrintNumbersBetweenTwoNumbers ()
        {
			//TASK: User enters 2 numbers. First one is beginning, second - end. Using for loop print all numbers between two numbers and also their squares.
			//UŽDUOTIS: Vartotojas įveda du skaičius, tai yra rėžius. Naudojant for ciklą atspausdinti visus skaičius ir jų kvadratus.

            Console.WriteLine("Enter two int numbers to make numbers range:");
			Console.WriteLine("First number");
            int number1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Second number");
            int number2 = Convert.ToInt32(Console.ReadLine());


			if (number1 >= number2)
			{
                Console.WriteLine("Ranges are incorrect, because second number is higher:");
			}
			else
			{
                Console.WriteLine("Number and their squares between number ranges:");
				for (int i = number1; i <= number2; i++)
				{
                    Console.Write($"{i} {i * i} \n"); //if its double, u can use Math.Pow
				}
			}
            
        }
    }
}
