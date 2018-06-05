using System;
namespace CSharpCoursesPractice
{
    public class LessonFourMethodsFunctions
    {
        public static void Main ()
        {
            //All tasks appear here:
            //Užduotys paleidžiamos čia:

            //BodyMassIndex();
            //GetThreeNumbersDoSomeThings();
            //IsPrimal();
            //RandomNumbers();
            //GuessNumberInRange();
            //ChangeNumberRefAndOut();
            //NumberIsTwoPrimalNumberSum();
            ConvertNumberToWords();


            Console.ReadKey();
		}

		static void ConvertNumberToWords()
		{
            //TASK: Program prints int number to words
            //UŽDUOTIS: Programa atspausdina int skaičių žodžiais

            int number = 0;

			string input = EnterNumber();

            if (CheckIfItsANumber(input) == true)
			{
				number = ConvertToInt32(input);
				if (CheckIfZero(number) == false)
				{
					if (CheckIfNumberIsInRange(number) == true)
					{
                        int digitsCount = CalculateHowManyDIgits(number);
                        number = CheckIfNumberIsNegative(number);
						ConvertToWords(number, digitsCount);
					}
					else
					{
						Console.WriteLine("Nepatenka į rėžius!");
					}
				}
			}
			else
			{
				Console.WriteLine("That's not a number!");
			}
		}
        static bool CheckIfZero(int number)
		{
            bool isZero = false;
			if (number == 0)
			{
				Console.WriteLine("Nulis");
				isZero = true;
			}

			return isZero;
		}
        static string EnterNumber()
		{
			Console.WriteLine("Enter int number from -999999999 to 999999999:");
			string input = Console.ReadLine().Trim();

			return input;
		}
		static bool CheckIfItsANumber(string input)
		{
            int number;
            bool isNumber = int.TryParse(input, out number);

			return isNumber;
		}
        static int ConvertToInt32(string input)
		{
            int number = Convert.ToInt32(input);

			return number;
		}

        static bool CheckIfNumberIsInRange(int number)
		{
            bool inRange = false;
			if (number >= -999999999 && number <= 999999999)
			{
				inRange = true;
			}

			return inRange;
		}
        static int CalculateHowManyDIgits(int number)
		{
            int count = 0;
			if (number < 0)
			{
				number *= -1;
			}

			while (number >= 10)
			{
				number /= 10;
				count++;
			}
			count++;

			return count++;
		}
        static void ConvertToWords(int number, int digitCount)
		{
			switch (digitCount)
			{
				case 1:
					IkiDevyniu(number);
					break;
				case 2:
					Iki99(number);
					break;
				case 3:
					Iki999(number);
					break;
				case 4:
					Iki9999(number);
					break;
				case 5:
					Iki99999(number);
					break;
				case 6:
					Iki999999(number);
					break;
				case 7:
					Iki9999999(number);
					break;
				case 8:
					Iki99999999(number);
					break;
				case 9:
					Iki999999999(number);
					break;
				default:
					Console.WriteLine("Taip negali būti!");
					break;
			}
		}
        static int CheckIfNumberIsNegative (int number)
        {
            if (number < 0)
			{
				Console.Write("minus ");
                number *= -1;
			}

            return number;
        }

        static void Iki999999999(int number)
		{
            int reminder = number % 1000000;
			number /= 1000000;
			Iki999(number);
			if (number % 10 == 0)
            {
				Console.Write("milijonų ");
			}
			else if (number % 10 == 1)
			{
				Console.Write("milijonas ");
			}
            else if (number % 10 > 1)
            {
                Console.Write("milijonai ");
            }
			Iki999999(reminder);
		}

        static void Iki99999999(int number)
		{
            int reminder = number % 1000000;
			number /= 1000000;
			Iki99(number);
			if (number % 10 == 0 || number > 10 && number < 20)
			{
				Console.Write("milijonų ");
			}
			else
			{
				Console.Write("milijonai ");
			}
			Iki999999(reminder);
		}

        static void Iki9999999(int number)
		{
            int reminder = number % 1000000;
			number /= 1000000;
			IkiDevyniu(number);
			if (number > 1 && number < 10)
			{
				Console.Write("miljonai ");
			}
			else if (number == 1)
			{
				Console.Write("miljonas ");
			}
			Iki999999(reminder);
		}

        static void Iki999999(int number)
		{
            int reminder = number % 1000;
			number /= 1000;
			Iki999(number);
			if (number % 10 == 0 && number > 0)
			{
				Console.Write("tūkstančių ");
			}
			else if (number > 1)
			{
				Console.Write("tūkstančiai ");
			}
			Iki999(reminder);
		}

        static void Iki99999(int number)
		{
            int reminder = number % 1000;
			number /= 1000;
			Iki99(number);
			if (number % 10 == 0 || number > 10 && number < 20)
			{
				Console.Write("tūkstančių ");
			}
			else
			{
				Console.Write("tūkstančiai ");
			}
			Iki9999(reminder);
		}

        static void Iki9999(int number)
		{
            int reminder = number % 1000;
			number /= 1000;
			IkiDevyniu(number);
			if (number > 1 && number < 10)
			{
				Console.Write("tūkstančiai ");
			}
			else if (number == 1)
			{
				Console.Write("tūkstantis ");
			}
			Iki999(reminder);
		}

        static void Iki999(int number)
		{
            int reminder = number % 100;
			number /= 100;
			IkiDevyniu(number);
			if (number > 1)
			{
				Console.Write("šimtai ");
			}
			else if (number == 1)
			{
				Console.Write("šimtas ");
			}
			Iki99(reminder);
		}
        static void IkiDevyniu(int number)
		{
			if (number < 0)
			{
				Console.Write("minus ");
				number *= -1;
			}

			switch (number)
			{
				case 1:
					Console.Write("vienas ");
					break;
				case 2:
					Console.Write("du ");
					break;
				case 3:
					Console.Write("trys ");
					break;
				case 4:
					Console.Write("keturi ");
					break;
				case 5:
					Console.Write("penki ");
					break;
				case 6:
					Console.Write("šeši ");
					break;
				case 7:
					Console.Write("septyni ");
					break;
				case 8:
					Console.Write("aštuoni ");
					break;
				case 9:
					Console.Write("devyni ");
					break;
				default:
					break;
			}
		}
        static void Iki99(int number)
		{
			if (number < 0)
			{
				Console.Write("minus ");
				number *= -1;
			}

			if (number < 20 && number > 10)
			{
				TillTwenty(number);
			}
			else
			{
				Print(number);
			}
		}
        static void Print(int number)
		{
            int reminder = number % 10;
			number /= 10;
			Tens(number);
			IkiDevyniu(reminder);
		}
        static void Tens(int number)
		{
			switch (number)
			{
				case 1:
					Console.Write("dešimt ");
					break;
				case 2:
					Console.Write("dvidešimt ");
					break;
				case 3:
					Console.Write("trysdešimt ");
					break;
				case 4:
					Console.Write("keturiasdešimt ");
					break;
				case 5:
					Console.Write("penkiasdešimt ");
					break;
				case 6:
					Console.Write("šešiasdešimt ");
					break;
				case 7:
					Console.Write("septyniasdešimt ");
					break;
				case 8:
					Console.Write("aštuoniasdešimt ");
					break;
				case 9:
					Console.Write("devyniasdešimt ");
					break;
				default:
					break;
			}
		}
        static void TillTwenty(int number)
		{
			switch (number)
			{
				case 11:
					Console.Write("vienuolika ");
					break;
				case 12:
					Console.Write("dvylika ");
					break;
				case 13:
					Console.Write("trylika ");
					break;
				case 14:
					Console.Write("keturiolika ");
					break;
				case 15:
					Console.Write("penkiolika ");
					break;
				case 16:
					Console.Write("šešiolika ");
					break;
				case 17:
					Console.Write("septyniolika ");
					break;
				case 18:
					Console.Write("aštuoniolika ");
					break;
				case 19:
					Console.Write("devyniolika ");
					break;
				default:
					break;
			}
		}

		static void NumberIsTwoPrimalNumberSum()
		{
            //TASK: Write a program to Check Whether a Number can be Express as Sum of Two Prime Numbers.
            //UŽDUOTIS: Patikrinti ar įvestas skaičius yra dviejų pirminių skaičių suma

            Console.WriteLine("Enter int number:");
			int inputNumber = Convert.ToInt32(Console.ReadLine());

            int primalOne = 0;
			for (int i = 2; i < inputNumber; i++)
			{
				//tikrinama ar skaičius dalinasi be liekanos
                bool notPrimal = false;
				for (int j = 2; j < i; j++)
				{
					if (i % j == 0)
					{
						notPrimal = true;
					}
				}
				//randamas pirminis ir toliau tikrinama ar pirminisVienas yra pirminis
				if (!notPrimal)
				{
					primalOne = inputNumber - i;
                    int divideNumber = 2;
					while (divideNumber < primalOne)
					{
						if (primalOne % divideNumber == 0)
						{
							primalOne = 0;
						}
						divideNumber++;
					}
				}
				if (primalOne + i == inputNumber && primalOne != 1)
				{
					Console.WriteLine($"Entered number {inputNumber} is sum of those two numbers: {i} + {primalOne}");
				}
			}
		}

		static void ChangeNumberRefAndOut()
		{
            //TASK: Use ref and out. 
            //Užduotis
			//NAUDOJANT REF IR OUT
			//OUT gali grąžinti daugiau nei 1 reikšmę

			int number = 5;
			IncreaseNormal(number);
			Console.WriteLine("after normal: {0}", number);
			IncreseRef(ref number);
			Console.WriteLine("after ref: {0}", number);
			IncreaseOut(out number);
			Console.WriteLine("after out: {0}", number);
		}
		static void IncreaseNormal(int number)
		{
			number++;
			//Console.WriteLine("Changed " + number);
		}
		static void IncreseRef(ref int number)
		{
			number++;
		}
		static void IncreaseOut(out int number)
		{
			//BŪTINA IŠ NAUJO SUSIKURtI REIKŠMĘ
			number = 5;
			number++;
		}

		static void GuessNumberInRange()
		{
            //TASK: Guess number which is in range of two random numbers
            //UŽDUOTIS: Atspėti skaičių, kuris yra tarp dviejų random skaičių

			Random rnd = new Random();
            int fromNumber, toNumber;
			do
			{
				fromNumber = rnd.Next(0, 50);
				toNumber = rnd.Next(0, 50);
            } while (fromNumber > toNumber);

            int guessedNumber = EnterInRange(fromNumber, toNumber);
			Console.WriteLine("Congrats! Your lucky number is {0}, numbers of range were: {1} ir {2}.", guessedNumber, fromNumber, toNumber);
		}
        static int EnterInRange(int start, int end)
		{
			Console.WriteLine("Computer randomised two numbers between 0 and 50.\nGuess int number whis is in range of two numbers:");
            int guessedNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"TEST: {guessedNumber} range: {start} and {end}"); //TEST
			while (guessedNumber < start || guessedNumber > end)
			{
				Console.WriteLine("Wrong guess! Try again!");
				guessedNumber = Convert.ToInt32(Console.ReadLine());
			}

			return guessedNumber;
		}

		static void RandomNumbers()
		{
            //TASK: User selects option, gets random number
            //UŽDUOTIS: Vartotojas pasirenka iš kurio krepšelio gauti random numerį

			Console.WriteLine("Select an option to get the number.");
			Console.WriteLine("1 - D20; \n2 - D10; \n3 - D6;");
            int input = Convert.ToInt32(Console.ReadLine());

			switch (input)
			{
				case 1:
					Console.WriteLine($"Number from D20 basket:");
					Console.WriteLine(D20());
					break;
				case 2:
					Console.WriteLine($"Number from D10 basket:");
					Console.WriteLine(D10());
					break;
				case 3:
					Console.WriteLine($"Number from D6 basket:");
					Console.WriteLine(D6());
					break;
				default:
					Console.WriteLine("Wrong input! Try again!");
					break;
			}
		}
		static int D20()
		{
            int number = new Random().Next(1, 20);
			return number;
		}
		static int D10()
		{
            int number = new Random().Next(1, 10);
			return number;
		}
		static int D6()
		{
            int number = new Random().Next(1, 6);
			return number;
		}

        static void IsPrimal ()
        {
			//TASK: check if number is primal. Return true or false
			//UŽDUOTIS: patikrinti ar skaičius yra pirminis. Grąžinti bool reikšmę

            Console.WriteLine("Enter int number:");
            int number = Convert.ToInt32(Console.ReadLine());

            bool answer = IfPrimal(number);

			if (answer == true)
			{
				Console.WriteLine("Number {0} is primal.", number);
			}
			else
			{
				Console.WriteLine("Number {0} is NOT primal.", number);
			}
        }
        static bool IfPrimal(int number)
		{
            bool reminder = false;
            int divider = 2;
			while (divider < number)
			{
				if (number % divider == 0)
				{
					reminder = false;
					break;
				}
				else
				{
					reminder = true;
				}
				divider++;
			}

            int number2 = Convert.ToInt32(Console.ReadLine());
            if (number > 1)
            {
                for (int i = 2; i < number2; i++)
                {
                    if (number2 % i == 0)
                    {
                        Console.WriteLine("Number is not primal.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Sveikiname {number} is primal.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Enter next number!");
                number2 = Convert.ToInt32(Console.ReadLine());
            }
            return reminder;
		}

		static void GetThreeNumbersDoSomeThings()
		{
            //TASK: get 3 int numbers and check which one is the biggest, after that check if first number is in range between two other numbers
            //UŽDUOTIS: patikrinti, kuris skaičius iš 3 yra didžiausias, paskui patikrinti ar pirmas skaičius yra tarp kitų dviejų

            Console.WriteLine("Enter three int numbers:");
			Console.WriteLine("First number:");
            int number1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Second number:");
            int number2 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Third number:");
            int number3 = Convert.ToInt32(Console.ReadLine());

            int biggestNumber = Max(number1, number2, number3);

			if (biggestNumber == 0)
			{
				Console.WriteLine("All numbers are equal.");
			}
			else if (biggestNumber == 1)
			{
				Console.WriteLine("Will not hit that.");
			}
			else
			{
				Console.WriteLine("Biggest number is {0}", biggestNumber);
			}

			Console.WriteLine("Checking if first number is between two other numbers:");
            bool isInRange = InRange(number1, number2, number3);
			Console.WriteLine(isInRange);
		}
        static bool InRange(int number1, int number2, int number3)
		{
			if (number1 > number2 && number1 < number3)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
        static int Max(int number1, int number2, int number3)
		{
			if (number1 > number2 && number1 > number3)
			{
				return number1;
			}
			else if (number2 > number1 && number2 > number3)
			{
				return number2;
			}
			else if (number3 > number1 && number3 > number2)
			{
				return number3;
			}
			else if (number1 == number2 && number1 == number3 && number2 == number3)
			{
				return 0;
			}
			else
			{
				return 1;
			}
		}

		static void BodyMassIndex()
		{
            //TASK: calculate Body mass index(BMI)
            //UŽDUOTIS: paskaičiuokite KMI

			Console.WriteLine("Let's see what's your BMI is.");
			Console.WriteLine("Enter your weight in kilograms:");
            double weight = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Enter your height in metres:");
            double height = Convert.ToDouble(Console.ReadLine());

            double bmi = CalculateBMI(weight, height);
			Console.WriteLine("Your BMI is: {0}", bmi);

			EstimateBMI(bmi);
		}
        static double CalculateBMI(double weight, double height)
		{
            double bmi = weight / Math.Pow(height, 2); //formulė kmi = svoris dalinta iš ūgio pakleto kvadratu

			return bmi;
		}
        static void EstimateBMI(double bmi)
		{
			if (bmi < 15)
			{
				Console.WriteLine("Very severely underweight");
			}
			else if (bmi >= 15 && bmi < 18.5)
			{
				Console.WriteLine("Underweight");
			}
			else if (bmi >= 18.5 && bmi < 25)
			{
				Console.WriteLine("Normal (healthy weight)");
			}
			else if (bmi >= 25 && bmi < 30)
			{
				Console.WriteLine("Overweight");
			}
			else if (bmi >= 30 && bmi < 40)
			{
				Console.WriteLine("Obese");
			}
			else if (bmi >= 40)
			{
				Console.WriteLine("Very severely obese");
			}
		}
	}
}
