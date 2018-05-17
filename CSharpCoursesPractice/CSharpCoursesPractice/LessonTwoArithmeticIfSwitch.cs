using System;
namespace CSharpCoursesPractice
{
    public class LessonTwoArithmeticIfSwitch
    {
        public static void Main()
        {
            //All tasks appear here:
            //Užduotys paleidžiamos čia:

            //FindCircleAreaAndLength();
            //ConvertMetersPerSecondToKmPerHour();
            //TestingMathOperators();
            //ComparisonOperators();
            //IfAdult();
            //IfNumberIsEven();
            //ThreeNumbers();
            //ThreNumbersVol2();
            //TestingSwitchStatement();
            //ChooseADrink();
            //FahrenheitToCelsius();
            //Bakery();

			Console.ReadKey();
        }

        public static void Bakery ()
        {
			//TASK: simple app where you fill info suited for bakery
			//UŽDUOTIS: kepyklos aplikacija padedanti apskaičiuoti reikiamą informaciją

            const int workingHours = 8;
			Console.WriteLine("Enter how many bread loafs employee can bake per hour.");
            int breadCount = Convert.ToInt32(Console.ReadLine()); //kiek iškeps vienas darbuotojas per valandą
			Console.WriteLine("How many employees work in bakery?");
            int employees = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("What's the prime cost?");
            float primeCost = Convert.ToSingle(Console.ReadLine());
			Console.WriteLine("How much costs one loaf of bread?");
            float breadCost = Convert.ToSingle(Console.ReadLine());
			int bakedBreadPerDay = breadCount * workingHours * employees;
            float PrimeCostAll = primeCost * bakedBreadPerDay;
            float income = breadCost * bakedBreadPerDay;
            float profit = income - PrimeCostAll;

			Console.WriteLine($"Loafs per day: {bakedBreadPerDay};\nPrime cost for all: {PrimeCostAll};\nIncome: {income};\nProfit: {profit};");
        }

        public static void FahrenheitToCelsius()
        {
            //TASK: convert Fahrenheit to Celsius
            //UŽDUOTIS: konvertuoti Farenheito įvestį į Celsijų

            float fahrenheit;
			float celsius;
			Console.WriteLine("Enter degrees in Fahrenheit.");
            fahrenheit = Convert.ToInt32(Console.ReadLine());

            celsius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine($"Degrees in Celsius: {celsius}");
        }

        public static void ChooseADrink()
        {
			//TASK: write a code which lets to choose a drink
			//UŽDUOTIS: parašyti kodą, kuris leidžia pasirinkti gėrimą

			Console.WriteLine("Choose what would you like to drink:\n1 - soda;\n2 - tea;\n3 - cocoa;\n4- coffee;\n5 - nothing;");
            Console.WriteLine("Enter a number:");
			int input = Convert.ToInt32(Console.ReadLine());
			switch (input)
			{
				case 1:
					Console.WriteLine("Jūs pasirinkote limonadą!");
					break;
				case 2:
					Console.WriteLine("Jūs pasirinkote arbatą!");
					break;
				case 3:
					Console.WriteLine("Jūs pasirinkote kakavą!");
					break;
				case 4:
					Console.WriteLine("Jūs pasirinkote kavą!");
					break;
				case 5:
					Console.WriteLine("Jūs pasirinkote, kad nieko nenorite!");
					break;
				default:
					Console.WriteLine("Blogas įvestas pasirinkimas!");
					break;
			}
        }

        public static void TestingSwitchStatement ()
        {
			//TASK: enter 3 int numbers. Test Switch statement
			//UŽDUOTIS: įvesti 3 int skaičius. Išbandyti switch sąlygą

			Console.WriteLine("Enter first int number, please.");
			int numb1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter second int number, please.");
			int numb2 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter third int number, please.");
			int numb3 = Convert.ToInt32(Console.ReadLine());

			switch (numb1)
			{
				case 1:
					Console.WriteLine(numb1 + numb2 + numb3);
					break;
				case 2:
					Console.WriteLine(numb1 - numb3);
					break;
				case 3:
					Console.WriteLine(numb2 * numb3);
					break;
				default:
					Console.WriteLine("Enter is not valid.");
					break;
			}
        }

        public static void ThreNumbersVol2 ()
        {
			//TASK: enter 3 int numbers. Do some stuff
			//UŽDUOTIS: įvesti 3 int skaičius. Atlikti veiksmus

			Console.WriteLine("Enter first int number, please.");
			int numb1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter second int number, please.");
			int numb2 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter third int number, please.");
			int numb3 = Convert.ToInt32(Console.ReadLine());

            bool ifTrue = true;

            if (numb1 > numb2 && numb1 < 100)
			{
				Console.WriteLine($"1. {ifTrue}");
			}
			else
			{
				ifTrue = false;
				Console.WriteLine($"1. {ifTrue}");
			}

            if (numb2 > 0 && numb2 > numb1)
			{
				Console.WriteLine($"2. {ifTrue}");
			}
			else
			{
				ifTrue = false;
				Console.WriteLine($"1. {ifTrue}");
			}

            if (numb1 > numb2 && numb1 > numb3 || numb3 > 0)
			{
				Console.WriteLine($"2. {ifTrue}");
			}
			else
			{
				ifTrue = false;
				Console.WriteLine($"1. {ifTrue}");
			}

            if (numb3 >= 5 && numb3 <= 10 || numb3 > numb1 || numb3 > numb2)
			{
				Console.WriteLine($"2. {ifTrue}");
			}
			else
			{
				ifTrue = false;
				Console.WriteLine($"1. {ifTrue}");
			}
        }

        public static void ThreeNumbers ()
        {
			//TASK: enter 3 int numbers. Find the biggest
			//UŽDUOTIS: įvesti 3 int skaičius. Rasti didžiausią

			Console.WriteLine("Enter first int number, please.");
            int numb1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter second int number, please.");
            int numb2 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter third int number, please.");
            int numb3 = Convert.ToInt32(Console.ReadLine());

			if (numb1 > numb2 && numb1 > numb3)
			{
                Console.WriteLine($"The biggest number: {numb1}!");
			}
			else if (numb2 > numb1 && numb2 > numb3)
			{
                Console.WriteLine($"The biggest number: {numb2}!");
			}
			else if (numb3 > numb1 && numb3 > numb2)
			{
                Console.WriteLine($"The biggest number: {numb3}!");
			}
			else if ((numb1 == numb2) || (numb2 == numb3) || (numb1 == numb3))
			{
				if (numb1 == numb2 && numb1 > numb3)
				{
					Console.WriteLine("First and second ar equal and biggest.");
				}
				else if (numb1 > numb2 && numb1 == numb3)
				{
					Console.WriteLine("First and third ar equal and biggest.");
				}
				else if (numb2 == numb3 && numb2 > numb1)
				{
					Console.WriteLine("Second and third ar equal and biggest.");
				}
				else
				{
					Console.WriteLine("All numbers are equal.");
				}
			}
        }

        public static void IfNumberIsEven ()
        {
			//TASK: enter int number and check if it's even or not
			//UŽDUOTIS: įvesti skaičių, patikrinti ar lyginis, t.y. dalinasi iš 2 be liekanos

			Console.WriteLine("Enter int number, please.");
			int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0 && number != 0)
			{
                Console.WriteLine("Even number\nResult is " + (number / 2));
			}
			else if (number == 0)
			{
				Console.WriteLine("You entered 0");
			}
			else
			{
				Console.WriteLine("Not even number");
			}
        }

        public static void IfAdult ()
        {
			//TASK: enter age and check if person is over 18 or not
			//UŽDUOTIS: įvesti amžių, patikrinti ar pilnametis

			Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());

			if (age >= 18 && age < 20)
			{
				Console.WriteLine("You're over 18 but can't buy alcohol.");
			}
			else if (age >= 20)
			{
				Console.WriteLine("You're old enough to do whatever you want!");
			}
			else
			{
				Console.WriteLine("You're too young, child!");
			}
        }

        public static void ComparisonOperators ()
        {
			//TASK: enter two int number and compare them
			//UŽDUOTIS: įvesti du skaičius ir palyginti juos

			Console.WriteLine("Enter first int number, please.");
            int numb1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter second int number.");
            int numb2 = Convert.ToInt32(Console.ReadLine());

            if (numb1 == numb2)
            {
                Console.WriteLine("Numbers are equal.");
            }
			if (numb1 != numb2)
            {
				Console.WriteLine("Not equal.");
			}
			if (numb1 > numb2)
            {
                Console.WriteLine($"{numb1} > {numb2}");
			}
			if (numb1 < numb2)
            {
				Console.WriteLine($"{numb1} < {numb2}");
			}
			if (numb1 >= numb2)
            {
				Console.WriteLine($"{numb1} > or = {numb2}");
			}
			if (numb1 <= numb2)
            {
				Console.WriteLine($"{numb1} < or = {numb2}");
			}
        }
        public static void TestingMathOperators ()
        {
			//TASK: test some math operators and their shortcuts
			//UŽDUOTIS: ištestuoti tam tikrus operatorių sutrumpinimus

            int number;
			Console.WriteLine("Įveskite sveiką skaičių:");
			number = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(number++); //Išsapsudino, tada pridėjo, dabar jau 6
			Console.WriteLine(++number); //Pridėjo 'number' + 1 ir išspausdino

            double numb = 5;
			numb = Math.Pow(numb, 2); //Pakelia kvadratu. Math.Pow(double x, double y)
			Console.WriteLine(numb);

			number += 5;
			Console.WriteLine(number);

			numb %= 6;
			Console.WriteLine(numb);
        }

        public static void ConvertMetersPerSecondToKmPerHour ()
        {
			//TASK: enter distance in meters and time in seconds and convert them to km/h
			//UŽDUOTIS: įvesti atstumą metrais, o laiką sekundėm. Paversti į km/h

			float speed;
			Console.WriteLine("Enter distance in meters, please.");
			float distanceM = Convert.ToSingle(Console.ReadLine());
			Console.WriteLine("Enter time in seconds.");
			float timeS = Convert.ToSingle(Console.ReadLine());

            float distanceKm = distanceM / 1000;
            float timeH = timeS / 3600;

            speed = distanceKm / timeH;
            Console.WriteLine($"Distance in km: {distanceKm}\nTime in h: {timeH}");
            Console.WriteLine($"Speed: {speed} km/h.");
        }

        public static void FindCircleAreaAndLength ()
        {
            //TASK: enter radius of the circle and calculate area and lenght of the circle.
            //UŽDUOTIS: įvesti apskritimo spindulį ir aspakičiuoti plotą bei ilgį.

            float area, length;
            const float pi = 3.14f; //const = konstanta, skaičiaus ne5manoma pakeist
			Console.WriteLine("Enter radius of the circle, please:");
            float radius = Convert.ToSingle(Console.ReadLine());

            length = 2 * pi * radius;
            area = pi * (radius * radius); //double r = 4; Math.Pow(r, 2); Su double galima naudoti šią Math funkciją

            Console.WriteLine($"Length (C) = {length}");
            Console.WriteLine($"Area (S) = {area}");
        }
    }
}
