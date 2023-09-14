using System.Xml.Serialization;

namespace Dag04_Övningar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Övningsuppgifter - Loopar

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





        }
    }
}