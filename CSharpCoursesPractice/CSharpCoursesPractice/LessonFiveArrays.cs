using System;
namespace CSharpCoursesPractice
{
    public class LessonFiveArrays
    {
        public static char[,] Map;
		public static int X, Y;

        public static void Main ()
        {
            string name = "Jonashbjksfbjsfbs";
            Console.WriteLine(name.Length);
            Console.WriteLine(name.Remove(5,12));
            Console.WriteLine(name.Remove(5));


            //All tasks appear here:
            //Užduotys paleidžiamos čia:

            //ChangeArrayAndRegroup();
            //FillInArray();
            MineSweeperApp();
            //Paleidimas();

            Console.ReadKey();
		}

        public static void MineSweeperApp ()
        {
            int index = 0;
            string[] enteredInfo;
            string input = " ";
            Console.WriteLine("Enter how many rows do you want on your map?");
            int numberOfRows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter mines. Char '*' is mine, if the field empty, please enter char '.'\nThen you enter all info, please leave an empty line and press Enter.");
            enteredInfo = new string[numberOfRows];

            do
            {
                Console.WriteLine("Enter a line:");
                input = Console.ReadLine();
                enteredInfo[index] = input.Trim();
                index++;
            } while (input != "" && index < numberOfRows);

            Console.WriteLine("You've entered all info.");

            foreach (string item in enteredInfo)
            {
                Console.WriteLine(item);
            }


            string[] sortedInfo; //= new string[numberOfRows];
            for (int i = 0; i < enteredInfo.Length; i++)
            {
                string newLine = "";
                if (enteredInfo[i] != null)
                {
                    for (int j = 0; j < enteredInfo[i].Length; j++)
                    {
                        if (enteredInfo[i][j] == '.' || enteredInfo[i][j] == '*')
                        {
                            newLine += enteredInfo[i][j];
                        }
                    }
                }
                enteredInfo[i] = newLine;
            }
            int count = 0;
            Console.WriteLine("sorted");
            foreach (string item in enteredInfo)
            {
                if (item != "")
                {
                    count++;
                }
            }
            Console.WriteLine("count " + count);
            sortedInfo = new string[count];
            int newIndex = 0;
            foreach (string item in enteredInfo)
            {
                if (item != "")
                {
                    sortedInfo[newIndex] = item;
                    newIndex++;
                }
            }

            foreach (string item in sortedInfo)
            {
                Console.WriteLine(item);
            }

            int shortest = 100;
            int longest = 0;
            int result;

            foreach (var item in sortedInfo)
            {
                if (item.Length < shortest)
                {
                    shortest = item.Length;
                }

                if (item.Length > longest)
                {
                    longest = item.Length;
                }
            }
            Console.WriteLine("Shortest line is " + shortest);
            Console.WriteLine("Longest line is " + longest);
            result = longest - shortest;

            for (int i = 0; i < sortedInfo.Length; i++)
            {
                if (sortedInfo[i].Length > shortest)
                {
                    sortedInfo[i] = sortedInfo[i].Remove(shortest);
                }
            }

            Console.WriteLine("shortened");
            foreach (string item in sortedInfo)
            {
                Console.WriteLine(item);
            }

            char[,] fieldInformation = new char[shortest,count];

            for (int i = 0; i < sortedInfo.Length; i++)
            {
                for (int j = 0; j < sortedInfo[i].Length; j++)
                {
                    if (sortedInfo[i][j] == '*')
                    {
                        fieldInformation[j, i] = '#';
                    }
                    else
                    {
                        //fieldInformation[j, i] = '1';

                    }
                }
            }

            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < shortest; j++)
                {
                    Console.Write(fieldInformation[j,i]);
                }
                Console.WriteLine();
            }
        }

        static void ChangeArrayAndRegroup()
		{
            //TASK: Where are same words. Change them to '!' and then put all '!' to the end of the array
            //UŽDUOTIS: Pakeisti visus dubliuotus žodžius '!' ir surūšiuoti juos į galą

			string[] data = { "Mano", "batai", "buvo", "Mano", "batai", "buvo", "du", "buvo", "du", "." };
            string[] newArray = new string[data.Length];
			for (int i = 0; i < data.Length; i++)
			{
				for (int j = i + 1; j < data.Length; j++)
				{
					if (data[i] == data[j])
					{
						data[i] = "!";
					}
				}
				Console.WriteLine(i + ". " + data[i]);
			}
            Console.WriteLine();
            //Įsivedam du kintamuosius, kurie padės surūšiuoti
            int count = 0;
			int index = 0;
			for (int i = 0; i < data.Length; i++)
			{
				if (data[i] == "!")
				{
					newArray[newArray.Length - 1 - count] = data[i];
					count++;
				}
				else
				{
					newArray[index] = data[i];
					index++;
				}
			}

			for (int i = 0; i < newArray.Length; i++)
			{
				Console.WriteLine(i + ". " + newArray[i]);
			}
		}

        static void FillInArray()
		{
            //TASK: Fill array with words
            //UŽDUOTIS: Surašyti žodžius į masyvą

            string[] texts = new string[5];
            string word = " ";

			Console.WriteLine("We need to fill in 5 words.");
			for (int i = 0; i < texts.Length; i++)
			{
				Console.WriteLine("Enter a word:");
				word = Console.ReadLine();
				texts[i] = word;
			}

			Console.WriteLine("Printing your array:");

			for (int i = 0; i < texts.Length; i++)
			{
				Console.Write(texts[i] + " ");
			}

			Console.WriteLine("\nPrinting backwards.");

			for (int i = texts.Length - 1; i > 0; i--)
			{
				Console.Write(texts[i] + " ");
			}
		}
    }
}
