using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // DSA Activity 2.3 - [Pacia, Chad Edrei]
            // Subject: Data Structure & Algorithm

           
            string name;
            int betAmount;
            string luckyNumbers;
            int multiplier;
            int prize;
            int[] winningNumbers = new int[6];

            
            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            Console.Write("Enter bet amount: ");
            betAmount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your lucky numbers:");
            luckyNumbers = Console.ReadLine();

            Random rand = new Random();
            multiplier = rand.Next(2, 6);
            prize = betAmount * multiplier;

            for (int i = 0; i < 6; i++)
            {
                int randomNumber = rand.Next(1, 50);
                bool isDuplicate = false;

                
                for (int j = 0; j < i; j++)
                {
                    if (winningNumbers[j] == randomNumber)
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (isDuplicate == false)
                {
                    winningNumbers[i] = randomNumber;
                }
                else
                {
                    i--; 
                }
            }

            
            Console.WriteLine();
            Console.WriteLine("DRAW RESULTS");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Amount: " + betAmount);
            Console.WriteLine("Multiplier x" + multiplier);
            Console.WriteLine("Prize: " + prize);
            Console.WriteLine();

            Console.WriteLine("Entry No's: " + luckyNumbers);
            Console.WriteLine();

            Console.WriteLine("*DRAWRESULT*");
            for (int i = 0; i < 6; i++)
            {
                Console.Write(winningNumbers[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
