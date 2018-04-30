using System;

namespace ConvertingIntToWords
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Pagrindinis();
        }

		static void Pagrindinis()
		{
			string input;
			int skaicius = 0;

			input = IveskSkaiciu();

			if (PaimkIrPatikrinkArSkaicius(input) == true)
			{
				skaicius = KonvertuokISkaiciu(input);
				if (PatikrinkArNulis(skaicius) == false)
				{
					if (ReziuTikrinimas(skaicius) == true)
					{
						int kiekis = SuskaiciuokKiekSkaitmenu(skaicius);
						VerskZodziais(skaicius, kiekis);
					}
					else
					{
						Console.WriteLine("Nepatenka į rėžius!");
					}
				}
			}
			else
			{
				Console.WriteLine("Įvedei ne skaičių!");
			}

		}

		static bool PatikrinkArNulis(int skaicius)
		{
			bool ArNulis = false;
			if (skaicius == 0)
			{
				Console.WriteLine("Nulis");
				ArNulis = true;
			}

			return ArNulis;
		}

		static string IveskSkaiciu()
		{
			Console.WriteLine("Įveskite sveiką skaičių nuo -999999999 iki 999999999:");
			string input = Console.ReadLine().Trim();

			return input;

		}

		static bool PaimkIrPatikrinkArSkaicius(string input)
		{
			int skaicius;
			bool arSkaicius = int.TryParse(input, out skaicius);

			return arSkaicius;
		}

		static int KonvertuokISkaiciu(string input)
		{
			int skaicius = Convert.ToInt32(input);

			return skaicius;
		}

		static bool ReziuTikrinimas(int skaicius)
		{
			bool reziai = false;
			if (skaicius >= -999999999 && skaicius <= 999999999)
			{
				reziai = true;
			}
			/*else
            {
                Console.WriteLine("Neteisingi rėžiai!");
            }*/

			return reziai;
		}

		static int SuskaiciuokKiekSkaitmenu(int skaicius)
		{
			int kiekis = 0;
			if (skaicius < 0)
			{
				skaicius *= -1;
			}

			while (skaicius >= 10)
			{
				skaicius /= 10;
				kiekis++;
			}
			kiekis++;

			return kiekis++;
		}

		static void VerskZodziais(int skaicius, int kiekis)
		{
			switch (kiekis)
			{
				case 1:
					IkiDevyniu(skaicius); //VIENETAI
					break;
				case 2:
					Iki99(skaicius); //DEŠIMTYS
					break;
				case 3:
					Iki999(skaicius); //ŠIMTAI
					break;
				case 4:
					Iki9999(skaicius); //TŪKSTANČIAI
					break;
				case 5:
					Iki99999(skaicius); //DEŠIMTYS TŪKSTANČIŲ
					break;
				case 6:
					Iki999999(skaicius); //ŠIMTAI TŪKSTANČIŲ
					break;
				case 7:
					Iki9999999(skaicius); //MILIJONAI
					break;
				case 8:
					Iki99999999(skaicius); //DEŠIMTYS MILJONŲ
					break;
				case 9:
					Iki999999999(skaicius); //ŠIMTAI MILIJONŲ
					break;
				default:
					Console.WriteLine("Taip negali būti!");
					break;
			}
		}

		static void Iki999999999(int skaicius)
		{
			int liekana;
			if (skaicius < 0)
			{
				Console.Write("minus ");
				skaicius *= -1;
			}

			liekana = skaicius % 1000000;
			skaicius /= 1000000;
			Iki999(skaicius);
			if (skaicius % 10 == 0 && skaicius > 0)
			{
				Console.Write("milijonų ");
			}
			else if (skaicius > 1)
			{
				Console.Write("milijonai ");
			}
			Iki999999(liekana);
		}

		static void Iki99999999(int skaicius)
		{
			int liekana;
			if (skaicius < 0)
			{
				Console.Write("minus ");
				skaicius *= -1;
			}

			liekana = skaicius % 1000000;
			skaicius /= 1000000;
			Iki99(skaicius);
			if (skaicius % 10 == 0 || skaicius > 10 && skaicius < 20)
			{
				Console.Write("milijonų ");
			}
			else
			{
				Console.Write("milijonai ");
			}
			Iki999999(liekana);
		}

		static void Iki9999999(int skaicius)
		{
			int liekana;
			if (skaicius < 0)
			{
				Console.Write("minus ");
				skaicius *= -1;
			}

			liekana = skaicius % 1000000;
			skaicius /= 1000000;
			IkiDevyniu(skaicius);
			if (skaicius > 1 && skaicius < 10)
			{
				Console.Write("miljonai ");
			}
			else if (skaicius == 1)
			{
				Console.Write("miljonas ");
			}
			Iki999999(liekana);
		}

		static void Iki999999(int skaicius)
		{
			int liekana;
			if (skaicius < 0)
			{
				Console.Write("minus ");
				skaicius *= -1;
			}

			liekana = skaicius % 1000;
			skaicius /= 1000;
			Iki999(skaicius);
			if (skaicius % 10 == 0 && skaicius > 0)
			{
				Console.Write("tūkstančių ");
			}
			else if (skaicius > 1)
			{
				Console.Write("tūkstančiai ");
			}
			Iki999(liekana);
		}

		static void Iki99999(int skaicius)
		{
			int liekana;
			if (skaicius < 0)
			{
				Console.Write("minus ");
				skaicius *= -1;
			}

			liekana = skaicius % 1000;
			skaicius /= 1000;
			Iki99(skaicius);
			if (skaicius % 10 == 0 || skaicius > 10 && skaicius < 20)
			{
				Console.Write("tūkstančių ");
			}
			else
			{
				Console.Write("tūkstančiai ");
			}
			Iki9999(liekana);
		}

		static void Iki9999(int skaicius)
		{
			int liekana;
			if (skaicius < 0)
			{
				Console.Write("minus ");
				skaicius *= -1;
			}

			liekana = skaicius % 1000;
			skaicius /= 1000;
			IkiDevyniu(skaicius);
			if (skaicius > 1 && skaicius < 10)
			{
				Console.Write("tūkstančiai ");
			}
			else if (skaicius == 1)
			{
				Console.Write("tūkstantis ");
			}
			Iki999(liekana);
		}

		static void Iki999(int skaicius)
		{
			int liekana;
			if (skaicius < 0)
			{
				Console.Write("minus ");
				skaicius *= -1;
			}

			liekana = skaicius % 100;
			skaicius /= 100;
			IkiDevyniu(skaicius);
			if (skaicius > 1)
			{
				Console.Write("šimtai ");
			}
			else if (skaicius == 1)
			{
				Console.Write("šimtas ");
			}
			Iki99(liekana);

		}

		static void IkiDevyniu(int skaicius)
		{
			if (skaicius < 0)
			{
				Console.Write("minus ");
				skaicius *= -1;
			}

			switch (skaicius)
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
					//Console.WriteLine("Tikrai ne!");
					break;
			}

		}

		static void Iki99(int skaicius)
		{
			if (skaicius < 0)
			{
				Console.Write("minus ");
				skaicius *= -1;
			}

			if (skaicius < 20 && skaicius > 10)
			{
				IkiDvidesimt(skaicius);
			}
			else
			{
				Isspaudink(skaicius);
			}
		}

		static void Isspaudink(int skaicius)
		{
			int liekana;

			liekana = skaicius % 10;
			skaicius /= 10;
			Dešimtys(skaicius);
			IkiDevyniu(liekana);
		}

		static void Dešimtys(int skaicius)
		{
			switch (skaicius)
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
					//Console.WriteLine("Tikrai ne!");
					break;
			}
		}

		static void IkiDvidesimt(int skaicius)
		{
			switch (skaicius)
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
					//Console.WriteLine("Tikrai ne!");
					break;
			}
		}

	}
}
