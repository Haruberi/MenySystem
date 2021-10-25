using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    class CharacterValues
    {
        public int Health { get; set; }
        public int Strength { get; set; }
        public bool Luck { get; set; }

        public CharacterValues()
        {
        }
    }
    class Character
    {
        public string Name { get; set; }

        public Character()
        {
        }
    }

    class Opponent
    {
        public string Name { get; set; }

        public Opponent()
        {
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            MainMenu();
        }

        static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Välkommen!");
            Console.WriteLine("Välj ett nummer från 0 - 16 : \n");
            Console.WriteLine("0. -- Avsluta applikationen --");
            Console.WriteLine("\t 1");
            Console.WriteLine("\t 2");
            Console.WriteLine("\t 3");
            Console.WriteLine("\t 4");
            Console.WriteLine("\t 5");
            Console.WriteLine("\t 6");
            Console.WriteLine("\t 7");
            Console.WriteLine("\t 8");
            Console.WriteLine("\t 9");
            Console.WriteLine("\t 10");
            Console.WriteLine("\t 11");
            Console.WriteLine("\t 12");
            Console.WriteLine("\t 13");
            Console.WriteLine("\t 14");
            Console.WriteLine("\t 15");
            Console.WriteLine("\t 16");

            string myOptions;
            myOptions = Console.ReadLine();
            switch (myOptions)
            {
                case "0":
                    Exit();
                    break;
                case "1":
                    Function1();
                    break;
                case "2":
                    Function2();
                    break;
                case "3":
                    Function3();
                    break;
                case "4":
                    Function4();
                    break;
                case "5":
                    Function5();
                    break;
                case "6":
                    Function6();
                    break;
                case "7":
                    Function7();
                    break;
                case "8":
                    Function8();
                    break;
                case "9":
                    Function9();
                    break;
                case "10":
                    Function10();
                    break;
                case "11":
                    Function11();
                    break;
                case "12":
                    Function12();
                    break;
                case "13":
                    Function13();
                    break;
                case "14":
                    Function14();
                    break;
                case "15":
                    Function15();
                    break;
                case "16":
                    Function16();
                    break;
                default:
                    break;
            }

            MainMenu();
        }
        static void Exit()
        {
            Console.Clear();
            Console.WriteLine("För att stänga ned applikationen:\n \n\t Tryck \t ENTER");
            Console.ReadLine();
            Environment.Exit(1);
        }

        static void Function1()
        {
            Console.Clear();
            Console.WriteLine("Hello world");
            Console.ReadLine();
        }
        static void Function2()
        {
            Console.Clear();
            Console.WriteLine("Skriv ditt förnamn: ");
            var userName = Console.ReadLine();
            Console.WriteLine("Skriv ditt efternamn: ");
            var userLastName = Console.ReadLine();
            Console.WriteLine("Skriv din ålder: ");
            var userAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hej {0} {1} som är {2} år!", userName, userLastName, userAge);
            Console.ReadLine();

        }
        static void Function3()
        {
            if (Console.ForegroundColor == ConsoleColor.Green)
            {
                Console.ResetColor();
            }
            else if (Console.ForegroundColor == ConsoleColor.Gray)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
        }
        static void Function4()
        {
            Console.Clear();
            var today = DateTime.Now;
            Console.WriteLine(today.ToLongDateString());
            Console.ReadLine();
        }
        static void Function5()
        {
            Console.Clear();
            Console.WriteLine("Skriv in värde 1: ");
            int value1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skriv in värde 2: ");
            int value2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Det största numret av de två värderna är: " + Math.Max(value1, Math.Max(value1, value2)));
            Console.ReadLine();
        }
        static void Function6()
        {
            Console.Clear();
            while (true)
            {
                var totalGuesses = 1;
                var randomNumbers = new Random().Next(1, 100);
                bool retryGame = true;

                while (true)
                {
                    Console.WriteLine("Gissa rätt nummer mellan 1 och 100: ");
                    var userGuess = Convert.ToInt32(Console.ReadLine());
                    if (userGuess < randomNumbers)
                    {
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("För lågt nummer, pröva igen!");
                        Console.WriteLine();
                        totalGuesses++;
                        continue;
                    }
                    else if (userGuess > randomNumbers)
                    {
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("För högt nummer, pröva igen!");
                        Console.WriteLine();
                        ++totalGuesses;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Du gissade rätt! Numret var {0}!", randomNumbers);
                        Console.WriteLine("Du gissade {0} {1}", totalGuesses, totalGuesses == 1 ? "gång" : "gånger");
                        Console.WriteLine("Vill du pröva igen? ja/nej");
                        string answer = Console.ReadLine();
                        if (answer != "ja")
                        {
                            retryGame = false;
                        }
                        break;
                    }
                }
                if (!retryGame) break;
            }
        }
        static void Function7()
        {
            Console.Clear();
            var userPath = @"c:\temp\UserText.txt";

            if (!File.Exists(userPath))
            {
                Console.WriteLine("Välkommen! \n Skriv en textrad för en ny fil: ");
                var userText = Console.ReadLine() + Environment.NewLine;
                File.WriteAllText(userPath, userText, Encoding.UTF8);
            }

            else if (File.Exists(userPath))
            {
                Console.WriteLine("Det fanns redan en textfil här ... \n \n Men nu är den raderad! \n \n \t Tryck \n \n \t ENTER \n \n För att börja om!");
                File.Delete(userPath);
            }
            Console.ReadLine();
        }
        static void Function8()
        {
            Console.Clear();
            var userPath = @"c:\temp\UserText.txt";
            var readUserText = File.ReadAllText(userPath);
            Console.WriteLine(readUserText);
            Console.ReadLine();
        }
        static void Function9()
        {
            Console.Clear();
            Console.WriteLine("Skriv in ett decimalnummer: ");
            var userDecimalInput = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Roten ur {0}", userDecimalInput + " är " + Math.Sqrt(userDecimalInput));
            var squareInput = Math.Pow(userDecimalInput, 2);
            Console.WriteLine("{0}^2 = {1}", userDecimalInput, squareInput);
            var squareInput10 = Math.Pow(userDecimalInput, 10);
            Console.WriteLine("{0}^10 = {1}", userDecimalInput, squareInput10);
            Console.ReadLine();
        }
        static void Function10()
        {
            Console.Clear();
            for (var i = 1; i <= 10; i++)
            {
                for (var j = 1; j <= 10; j++)
                {
                    Console.WriteLine("{0} * {1} = {2}\t", i, j, (i * j));
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        static void Function11()
        {
            Console.Clear();
            Console.WriteLine("Array med slumpmässiga tal: ");
            Random ranomIntNumbers = new Random();
            var randomArray = new int[5];
            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine(randomArray[i] = (int)(ranomIntNumbers.Next(1, 10)));
            }
            Console.WriteLine();
            Console.WriteLine("Array i stigande ordning: ");
            randomArray = randomArray.OrderBy(c => c).ToArray();
            foreach (var randomValueArray in randomArray)
            {
                Console.WriteLine(randomValueArray + " ");
            }
            Console.ReadLine();
        }
        static void Function12()
        {
            Console.Clear();
            string inputString, reverseString = string.Empty;
            Console.WriteLine("Skriv någonting: ");
            inputString = Console.ReadLine();

            if (inputString != null)
            {
                for (var i = inputString.Length - 1; i >= 0; i--)
                {
                    reverseString += inputString[i].ToString();
                }
                if (reverseString == inputString)
                {
                    Console.Clear();
                    Console.WriteLine("Strängen {0} är en palindrom och blir baklänges {1}", inputString, reverseString);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Strängen {0} är inte en palindrom", inputString);
                }
            }
            Console.ReadLine();
        }
        static void Function13()
        {
            Console.Clear();
            Console.WriteLine("Skriv in en startsiffra: ");
            var start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skriv in en slutsiffra: ");
            var end = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Siffrona mellan de två inputsen är: \n");

            for (int i = start; i < end; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
        static void Function14()
        {
            Console.Clear();
            Console.WriteLine("Skriv några siffror separerade med kommatecken :");
            var commaValues = Console.ReadLine();

            var numbers = commaValues.Split(',');

            var evenNum = Convert.ToInt32(numbers[0]);

            foreach (var str in numbers)
            {
                var number = Convert.ToInt32(str);
                if (number % 2 == 0)
                {
                    Console.WriteLine("Siffrorna är jämna");
                }
                else
                {
                    Console.WriteLine("Siffrona är udda");
                }
            }
            Console.ReadLine();
        }

        static void Function15()
        {
            Console.Clear();
            var sum = 0;
            Console.WriteLine("Skriv ut några siffror separerade med kommatecken: ");
            var addValues = Console.ReadLine();
            var addNumbers = addValues.Split(',');

            var addedNum = Convert.ToInt32(addNumbers[0]);

            foreach (var addStr in addNumbers)
            {
                var addNumber = Convert.ToInt32(addStr);
                sum += Convert.ToInt32(addNumber);
            }
            Console.WriteLine("Summan av siffrorna är: " + sum);
            Console.ReadLine();
        }

        static void Function16()
        {
            Console.Clear();
            var isLucky = false;
            var rnd = new Random().Next(1, 10);
            var characterValues = new CharacterValues();
            var character = new Character();
            var opponent = new Opponent();

            Console.WriteLine("Skapa ett namn för din karaktär: ");
            var userCharacter = character.Name = Console.ReadLine();
            Console.WriteLine("Skapa ett namn för din motståndare: ");
            var userOpponent = opponent.Name = Console.ReadLine();


            if (characterValues.Health > 5)
            {
                Console.Clear();
                //Karaktären
                Console.WriteLine("\t \n ** Karaktär ** \n \n \t -- {0} -- \n Hälsa: {1} \n Styrka: {2} \n Tur: {3}",
                    character.Name,
                    characterValues.Health,
                    characterValues.Strength,
                    isLucky == true);
                Console.WriteLine();
                //Motståndaren
                Console.WriteLine("\t \n ** Motståndaren** \n \n \t -- {0} -- \n Hälsa: {1} \n Styrka: {2} \n Tur: {3}",
                    opponent.Name,
                    characterValues.Health,
                    characterValues.Strength,
                    isLucky == true);
            }
            else if (characterValues.Health < 5)
            {
                //Karaktären
                Console.Clear();
                Console.WriteLine("\t ** Karaktär ** \n \n \t -- {0} -- \n Hälsa: {1} \n Styrka: {2} \n Tur: {3}",
                    character.Name,
                    characterValues.Health,
                    characterValues.Strength,
                    isLucky == false);
                //Motståndaren
                Console.WriteLine();
                Console.WriteLine("\t ** Motståndare ** \n \n \t -- {0} -- \n Hälsa: {1} \n Styrka: {2} \n Tur: {3}",
                    opponent.Name,
                    characterValues.Health,
                    characterValues.Strength,
                    isLucky == false);
            }
            Console.ReadLine();
        }
    }
}



