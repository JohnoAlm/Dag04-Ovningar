using System.Net.Http.Headers;
using System.Xml.Serialization;

namespace Dag04_Övningar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ÖVNINGSUPPGIFTER - LOOPAR

            ////1.

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            ////2.
            //Console.Write("Mata in ett tal: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Mata in ett större tal: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //while (num2 < num)
            //{
            //    Console.WriteLine("\nTalet kan inte vara mindre än det ursprungliga talet");
            //    Console.Write("\nFörsök igen: ");
            //    num2 = Convert.ToInt32(Console.ReadLine());
            //}

            //for(int i = num + 1; i < num2 ; i++)
            //{
            //    Console.WriteLine(i);
            //}

            ////3.
            //char result = 'J';

            //while(result == 'J')
            //{
            //    Console.Write("Mata in ett tal: ");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("Mata in ytterligare ett tal: ");
            //    int num2 = Convert.ToInt32(Console.ReadLine());

            //    int sum = num + num2;

            //    Console.WriteLine($"Summan av de två talen är: {sum}");

            //    Console.WriteLine("\nVill du fortsätta (J/N)?");

            //    string userInput = Console.ReadLine().ToUpper();

            //    var success = char.TryParse(userInput, out result);

            //    while (!success)
            //    {
            //        Console.Write("Fel inmatning försök igen: ");
            //        userInput = Console.ReadLine().ToUpper();
            //        success = char.TryParse(userInput, out result);
            //    }
            //    if(result == 'N')
            //    {
            //        System.Environment.Exit(0);
            //    }
            //}

            ////4.
            //int sum = 0;

            //for(int i = 0; i < 10; i++)
            //{
            //    Console.Write("Mata in ett tal: ");
            //    int num = Convert.ToInt32(Console.ReadLine());

            //    sum += num;
            //}

            //Console.WriteLine($"Summan av det du matat in är: {sum}");

            ////5.
            //Console.Write("Mata in ett tal: ");
            //int num = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i < num; i++)
            //{
            //    Console.WriteLine(i);
            //}

            ////6.
            //int senaste = 0, nästsenaste = 0, tidigaste = 0;

            //for (int i = 0; i < 3; i++) 
            //{
            //    Console.Write("Mata in en temperatur (°C): ");
            //    int temp = Convert.ToInt32(Console.ReadLine());

            //    if(i == 0)
            //        senaste = temp;

            //    else if(i == 1) 
            //        nästsenaste = temp;

            //    else if(i == 2)
            //        tidigaste = temp;
            //}

            //int average = (senaste + nästsenaste + tidigaste) / 3;

            //Console.WriteLine($"\nMedeltemperaturen är: {average}°C");

            //if (average > 25)
            //{
            //    Console.WriteLine("\nAlarm");
            //}

            ////6. c)

            //List<int> temperatures = new List<int>();   

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.Write("Mata in en temperatur (°C): ");
            //    int temp = Convert.ToInt32(Console.ReadLine());

            //    temperatures.Add(temp);
            //}

            //int sum = 0;

            //foreach(int temp in temperatures)
            //{
            //    sum += temp;
            //}

            //int average = sum / 3;

            //Console.WriteLine($"\nMedeltemperaturen är: {average}°C");

            //if( average > 25 )
            //    Console.WriteLine("\nAlarm");

            ////7. 
            //char input = 'y';

            //Random random = new Random();

            //Console.WriteLine("Roll some dice!");
            //Console.WriteLine("Press any key to start...");
            //Console.ReadKey();

            //while(input == 'y')
            //{
            //    Console.WriteLine("\nRolling the dices...");
            //    Thread.Sleep(1000);
            //    Console.WriteLine("\nThe values are....");
            //    Thread.Sleep(1000);

            //    int randomNum = random.Next(1, 7);
            //    Console.WriteLine(randomNum);

            //    randomNum = random.Next(1, 7);
            //    Console.WriteLine(randomNum);

            //    Console.Write("\nRoll the dices again (y/n): ");
            //    string? userInput = Console.ReadLine().ToLower();

            //    bool success = char.TryParse(userInput, out input);

            //    while (!success)
            //    {
            //        Console.Write("\nInvalid input, please try again: ");
            //        userInput = Console.ReadLine().ToLower();
            //        success = char.TryParse(userInput, out input);
            //    }

            //    if(input == 'n') 
            //        System.Environment.Exit(0); 
            //}

            //---------------------------------------------------------------------------

            //CONDITIONS AND LOOPS 2 EXERCISES

            //1.
            //Console.Write("Mata in ett tal: ");

            //bool success = int.TryParse(Console.ReadLine(), out int number);

            //while (!success)
            //{
            //    Console.Write("Fel inmatning, försök igen: ");
            //    success = int.TryParse(Console.ReadLine(), out number);
            //}

            //if(number > 0)
            //    Console.WriteLine("Ditt tal är positivt");

            //else if(number < 0)
            //    Console.WriteLine("Ditt tal är negativt");

            //else if(number == 0)
            //    Console.WriteLine("Ditt tal är 0");

            //2.
            //Console.Write("Mata in ett tal: ");
            //bool success = int.TryParse(Console.ReadLine(), out int number);

            //while (!success) 
            //{
            //    Console.Write("Fel inmatning, försök igen: ");
            //    success = int.TryParse(Console.ReadLine(), out number);
            //}

            //Console.Write("Mata in ytterligare ett tal: ");
            //success = int.TryParse(Console.ReadLine(), out int number2);

            //while (!success)
            //{
            //    Console.Write("Fel inmatning, försök igen: ");
            //    success = int.TryParse(Console.ReadLine(), out number);
            //}

            //if(number > number2)
            //    Console.WriteLine($"{number} är störst");

            //else if(number2 > number)
            //    Console.WriteLine($"{number2} är störst");

            //else if(number == number2)
            //    Console.WriteLine(":(");

            ////3. 

            //Console.Write("Mata in ett tal: ");
            //bool success = int.TryParse(Console.ReadLine(), out int number);

            //while (!success)
            //{
            //    Console.Write("\nFel inmatning, försök igen: ");
            //    success = int.TryParse(Console.ReadLine(), out number);
            //}

            //Console.Write("\nMata in ytterligare ett tal: ");
            //success = int.TryParse(Console.ReadLine(), out int number2);

            //while (!success)
            //{
            //    Console.Write("\nFel inmatning, försök igen: ");
            //    success = int.TryParse(Console.ReadLine(), out number2);
            //}

            //Console.Write("\nVill du addera eller subtrahera? (+/-): ");

            //success = char.TryParse(Console.ReadLine(), out char output);

            //while (!success)
            //{
            //    success = char.TryParse(Console.ReadLine(), out output);
            //}

            //int sum;

            //switch (output) 
            //{
            //    case '+':
            //        sum = number + number2;
            //        Console.WriteLine($"\nSumman är: {sum}");
            //        break;

            //    case '-':
            //        sum = number - number2;
            //        Console.WriteLine($"\nSumman är: {sum}");
            //        break;
            //}

            ////4. 
            //double number = 0, number2 = 0;
            //Console.Write("Mata in ett tal: ");
            //bool success = double.TryParse(Console.ReadLine(), out number);

            //while (!success)
            //{
            //    Console.Write("\nFel inmatning, försök igen: ");
            //    success = double.TryParse(Console.ReadLine(), out number);
            //}

            //if (number != 0)
            //{
            //    Console.Write("\nMata in ytterligare ett tal: ");
            //    success = double.TryParse(Console.ReadLine(), out number2);

            //    while (!success)
            //    {
            //        Console.Write("\nFel inmatning, försök igen: ");
            //        success = double.TryParse(Console.ReadLine(), out number2);
            //    }
            //}
            //else if (number == 0)
            //{
            //    Console.WriteLine("Du kan inte dividera med 0!");
            //    System.Environment.Exit(0);
            //}

            //if (number2 != 0)
            //{
            //    double sum = number / number2;
            //    Console.WriteLine($"Summan är {Math.Round(sum, 2)}");
            //}
            //else if(number2 == 0)
            //{
            //    Console.WriteLine("Du kan inte dividera med 0!");
            //}

            ////5.
            //int number = 0, number2 = 0, number3 = 0;

            //Console.Write("Mata in ett tal: ");
            //bool success = int.TryParse(Console.ReadLine(), out number);

            //while (!success)
            //{
            //    Console.Write("\nFel inmatning, försök igen: ");
            //    success = int.TryParse(Console.ReadLine(), out number);
            //}

            //Console.Write("\nMata in ytterligare ett tal: ");
            //success = int.TryParse(Console.ReadLine(), out number2);

            //while (!success)
            //{
            //    Console.Write("\nFel inmatning, försök igen: ");
            //    success = int.TryParse(Console.ReadLine(), out number2);
            //}

            //Console.Write("\nMata in ytterligare ett tal: ");
            //success = int.TryParse(Console.ReadLine(), out number3);

            //while (!success)
            //{
            //    Console.Write("\nFel inmatning, försök igen: ");
            //    success = int.TryParse(Console.ReadLine(), out number3);
            //}

            //if(number > number2 && number > number3)
            //    Console.WriteLine($"Det största talet är: {number}");

            //else if (number2 > number && number2 > number3)
            //    Console.WriteLine($"Det största talet är: {number2}");

            //else if (number3 > number && number3 > number2)
            //    Console.WriteLine($"Det största talet är: {number3}");

            //else if(number == number2 && number == number3 && number2 == number3)
            //    Console.WriteLine(":O");

            ////6.
            //int number = 0;

            //Console.Write("Mata in ett tal: ");
            //bool success = int.TryParse(Console.ReadLine(), out number);

            //while (!success)
            //{
            //    Console.Write("\nFel inmatning, försök igen: ");
            //    success = int.TryParse(Console.ReadLine(), out number);
            //}

            //if(number > 10)
            //    Console.WriteLine("Ditt tal är större än 10");
            //else if (number < 10)
            //    Console.WriteLine("Ditt tal är mindre än 10");
            //else
            //    Console.WriteLine("Ditt tal är lika med 10");

            ////7.
            //int temp = 0;

            //while (true)
            //{
            //    Console.Write("Mata in en temperatur (°C): ");
            //    bool success = int.TryParse(Console.ReadLine(), out temp);

            //    while (!success)
            //    {
            //        Console.Write("\nFel inmatning, försök igen: ");
            //        success = int.TryParse(Console.ReadLine(), out temp);
            //    }

            //    if(temp < -10)
            //        Console.WriteLine("Det är jättekallt!");
            //    else if(temp >= -10 && temp < 0)
            //        Console.WriteLine("Det är kallt");
            //    else if(temp >= 0 && temp < 10)
            //        Console.WriteLine("Det är milt");
            //    else if(temp >= 10 && temp < 20)
            //        Console.WriteLine("Det är lagom");
            //    else if(temp >= 20 && temp < 30)
            //        Console.WriteLine("Det är varmt!");
            //    else if(temp >= 30)
            //        Console.WriteLine("Hjälp! Jag smälter!");
            //}

            //// LOOPS
            //8.
            //int i = -1;

            //while (i < 30)
            //{
            //    i++;
            //    Console.WriteLine(i);
            //}

            //9.
            //int i = 15;

            //while (i >= -5)
            //{
            //    Console.WriteLine(i);
            //    i--;
            //}

            //10.
            //int i = -1;

            //while(i < 45)
            //{
            //    if(i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //    i++;
            //}

            //11.
            //int i = -1;
            //do
            //{
            //    i++;
            //    Console.WriteLine(i);

            //} while (i < 100);

            //12.
            //for (int i = -5; i <= 23; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //13.
            //for (int i = -10; i >= -40; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //14.
            //for (int i = -30; i <= -10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //15.
            //int i = -1;

            //while (i <= 100)
            //{
            //    i++;

            //    if(i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //16.
            //int num; 

            //Console.WriteLine("Mata in ett tal: ");

            //bool success = int.TryParse(Console.ReadLine(), out num);

            //while (!success)
            //{
            //    Console.Write("\nFel inmatning, försök igen: ");
            //    success = int.TryParse(Console.ReadLine(), out num);
            //}

            //Console.WriteLine("\n");

            //for (int i = 0; i < num; i++)
            //{
            //    Console.WriteLine(num);
            //}

            //17. 
            //int i = -1;

            //while(i < 30)
            //{
            //    i++;

            //   if (i == 3 || i == 15 || i == 27)
            //    {
            //        Console.WriteLine("Hej");
            //    }

            //    Console.WriteLine(i);
            //}

            //18.
            //int num;

            //Console.Write("Mata in ett tal mellan 40 och 70: ");

            //bool success = int.TryParse(Console.ReadLine(), out num);

            //while (!success || num <= 40 || num >= 70)
            //{
            //    Console.Write("\nFel inmatning, försök igen: ");
            //    success = int.TryParse(Console.ReadLine(), out num);
            //}

            //Console.WriteLine("\n");

            //for (int i = 40; i <= 70; i++) 
            //{
            //    if (i == num)
            //        continue;

            //    Console.WriteLine(i);
            //}

            //19.

            //int i = 15;

            //while(i >= 7)
            //{
            //    i--;

            //    if(i % 2 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //20.
            //var userInput = String.Empty;

            //Console.Write("Skriv in en text: ");
            //var userText = Console.ReadLine();

            //Console.WriteLine("\n");

            //while (userInput != "SLUTA")
            //{
            //    Console.WriteLine(userText);
            //    Console.Write("\nOm du vill stoppa skriv \"Sluta\" annars skriv vadsomhelst: ");
            //    userInput = Console.ReadLine().ToUpper();
            //}

            //21.

            //a)
            //for (int row = 0; row < 6; row++) 
            //{
            //    for(int col = 0; col < row + 1; col++)
            //    {
            //        Console.Write("*");
            //    }   
            //    Console.WriteLine();
            //}

            //b)
            //for (int row = 0; row < 5; row++)
            //{
            //    for (int col = 0; col < row + 1; col++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for(int row = 1; row < 5; row++)
            //{
            //    for(int col = 4; col > row - 1; col--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //c)
            //for (int row = 0; row < 5; row++)
            //{
            //    for (int col = 0; col < row + 1; col++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int row = 1; row < 4; row++)
            //{
            //    for (int col = 4; col > row - 1; col--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int row = 0; row < 5; row++)
            //{
            //    for (int col = 0; col < row + 1; col++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int row = 1; row < 5; row++)
            //{
            //    for (int col = 4; col > row - 1; col--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //d)
            // Bra jobbat. Bra JOBBATT!!!!!

            //for (int row = 1; row <= 16; row *= 2)
            //{
            //    for (int col = 1; col < row + 1; col++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int row = 8; row >= 1; row /= 2)
            //{
            //    for (int col = 0; col < row; col++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //22.
            //Random random = new Random();

            //int correctNum = random.Next(1, 20);

            //int userNum;

            //int numberOfTries = 0;

            //Console.WriteLine("GISSA TALET!");

            //Console.WriteLine("\nDu har 5 liv!");

            //Console.WriteLine("----------------------------");

            //Console.Write("\nMata in ett tal mellan 1 och 20: ");

            //bool success = int.TryParse(Console.ReadLine(), out userNum);

            //while (!success)
            //{
            //    Console.Write("\nFel inmatning, försök igen: ");
            //    success = int.TryParse(Console.ReadLine(), out userNum);
            //}

            //while (userNum != correctNum && success)
            //{
            //    numberOfTries++;

            //    if(numberOfTries > 4)
            //    {
            //        Console.WriteLine("Du har förlorat, lycka till nästa gång!");
            //        Console.WriteLine("Spelet avslutas...");
            //        System.Environment.Exit(0);
            //    }
                

            //    if (userNum > correctNum && userNum <= 20)
            //    {
            //        Console.Write("Du gissade för högt, försök igen: ");
            //        success = int.TryParse(Console.ReadLine(), out userNum);
            //    }
                    
            //    else if(userNum < correctNum && userNum >= 1)
            //    {
            //        Console.Write("Du gissade för lågt, försök igen: ");
            //        success = int.TryParse(Console.ReadLine(), out userNum);
            //    }

            //    else if (userNum < 1 || userNum > 20)
            //    {
            //        Console.WriteLine("Talet måste vara mellan 1 och 20, försök igen: ");
            //        success = int.TryParse(Console.ReadLine(), out userNum);
            //    }

            //    while (!success)
            //    {
            //        Console.Write("\nFel inmatning, försök igen: ");
            //        success = int.TryParse(Console.ReadLine(), out userNum);
            //    }
            //}

            //Console.WriteLine("\nGrattis, du gissade rätt nummer!");
            //Console.WriteLine("\nTryck på valfri knapp för att avsluta...");
            //Console.ReadKey();





























        }
    }
}