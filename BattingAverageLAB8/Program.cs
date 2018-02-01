using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace LAB8
{
    class Program
    {


        public static float CalculateAverage(float sum1, int bases)
        {
            return sum1 / bases;

        }

        public static void Main(string[] args)
        {
            try
            {

                bool repeat1 = true, repeat2 = true;

                char choice;
                var reGex = new Regex("^[aA-za-z]");
                while (repeat1)
                {


                    Console.WriteLine("WELCOME TO THE BATTING AVERAGE AND SLUGGING AVERAGE CALCULATOR!");
                    Console.WriteLine(new string('=', 63));

                    Console.WriteLine("\nThis program will calculate the Batting and Slugging average for up to 5 players");
                    Console.WriteLine(new string('=', 80));

                    Console.WriteLine($"\nPlease enter the number of players that will bat(1-5): ");
                    Console.WriteLine(new string('=', 58));
                    int players = int.Parse(Console.ReadLine());

                    Console.WriteLine("\nPlease enter number of times the player will be at bat(1-5):  ");
                    int atBats = int.Parse(Console.ReadLine());

                    Console.WriteLine("\n[0] = OUT, [1]= SINGLE, [2] = DOUBLE, [3] = TRIPLE, [4] = HOME RUN!");

                    Console.WriteLine(new string('=', 67));

                    float[,] Playeratbats = new float[players, atBats];






                    for (int row = 0; row < players; row++)
                    {
                        Console.WriteLine($"\nPlease enter number of at bats for Player [{row + 1}]");



                        for (int column = 0; column < atBats; column++)
                        {
                            Playeratbats[row, column] = float.Parse(Console.ReadLine()); // playeratbats[0,0] sets the location in the index  

                        }




                    }




                    for (int row = 0; row < players; row++)
                    {
                        float sum1 = 0;
                        int count = 0;

                        for (int column = 0; column < atBats; column++)
                        {
                            sum1 += Playeratbats[row, column];

                            if (Playeratbats[row, column] > 0)
                            {
                                count++;
                            }
                        }
                        Console.WriteLine($"\nTHE RESULTS FOR PLAYER {row + 1}");
                        Console.WriteLine(new string('=', 25));
                        Console.WriteLine($"\nThe slugging average for PLAYER [{row + 1}] is : {CalculateAverage(sum1, atBats)}");
                        Console.WriteLine($"\nThe batting average for PLAYER [{row + 1}] is : {CalculateAverage(count, atBats)}");
                    }


                    //Validation 

                    Console.WriteLine("\nWould you like to run this program again ? Type (Y/N)");
                    choice = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    while (choice != 'n' && choice != 'N' && choice != 'y' && choice != 'Y')
                    {
                        Console.WriteLine("INVALID RESPONSE! PLEASE ENTER Y/N");
                        choice = Convert.ToChar(Console.ReadLine());
                    }
                    if (choice == 'y' || choice == 'Y')
                    {
                        repeat1 = true;
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("GOODBYE");
                        repeat1 = false;
                    }

                }
            }
            catch (FormatException)
            {
                Console.WriteLine("                          ^__^ ");
                Console.WriteLine(@"INVALID        START     / >.<\   ");
                Console.WriteLine(@"        INPUT!      OVER \  ^ /   ");

                Console.ReadKey();
            }
        }
    }
}
