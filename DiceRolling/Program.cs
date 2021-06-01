using System;

namespace DiceRolling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tWelcome the Dice rolling output determinator\n\n");
            Console.Write("\n\tEnter the number of dice to roll (Min = 1 and Max = 5) ");
            int x;
            while(!int.TryParse(Console.ReadLine(), out x) || x < 1 || x > 5)
            {
                Console.Write("\n\tInvalid input... please enter a value between 1 and 5 inclusive: ");               
            }
            Console.WriteLine();

            int count = 0;
            switch (x) 
            {                
                case 1:
                    for(int i = 1; i <= 6; i++)
                    {
                        Console.WriteLine("\t (" + i +")");
                        count++;                     
                    }
                    Console.WriteLine("\n\tTotal number of possible outcomes is: " + count);
                    break;
                
                case 2:
                    for (int i = 1; i <= 6; i++)
                    {
                        
                        for (int j = 1; j <= 6; j++)
                        {
                            Console.Write("\t(" + i + ", " + j + ")");
                            count++;
                        }
                        Console.WriteLine();                                               
                    }
                    Console.WriteLine("\n\tTotal number of possible outcomes is: " + count);
                    break;

                case 3:
                    for (int i = 1; i <= 6; i++)
                    {
                        for (int j = 1; j <= 6; j++)
                        {
                            for (int k = 1; k <= 6; k++)
                            {
                                Console.Write("\t(" + i + ", " + j + ", " + k + ")");
                                count++;
                            }
                            Console.WriteLine();                                                      
                        }                        
                    }
                    Console.WriteLine("\n\tTotal number of possible outcomes is: " + count); 
                    break;

                case 4:
                    for (int i = 1; i <= 6; i++)
                    {
                        for (int j = 1; j <= 6; j++)
                        {
                            for (int k = 1; k <= 6; k++)
                            {
                                for (int l = 1; l <= 6; l++)
                                {
                                    Console.Write("\t(" + i + ", " + j + ", " + k + ", " + l + ")");
                                    count++;
                                }
                                Console.WriteLine();
                            }                                                                                  
                        }                        
                    }
                    Console.WriteLine("\n\tTotal number of possible outcomes is: " + count);
                    break;

                case 5:
                    for (int i = 1; i <= 6; i++)
                    {
                        for (int j = 1; j <= 6; j++)
                        {
                            for (int k = 1; k <= 6; k++)
                            {
                                for (int l = 1; l <= 6; l++)
                                {
                                    for (int m = 1; m <= 6; m++)
                                    {
                                        Console.Write("\t(" + i + ", " + j + ", " + k + ", " + l + ", "+ m + ")");
                                        count++;
                                    }
                                    Console.WriteLine();
                                }
                            }                                                                               
                        }                        
                    }
                    Console.WriteLine("\n\tTotal number of possible outcomes is: " + count);
                    break;
            }

            Console.Write("\n\tPress any key to exit... ");
            Console.ReadKey();
        }
    }
}
