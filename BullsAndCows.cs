using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BullsAndCows
{
    class BullsAndCows
    {
        static void Main(string[] args)
        {
            
            Random rnd = new Random();
            int[] myNumber = new int[4];
            for (int i = 0; i < 4; i++)
            {
                myNumber[i] = rnd.Next(0, 10);
            }
            for (int i = 0; i < 3; i++)
            {
                while (myNumber[0] == myNumber[1] || myNumber[0] == myNumber[2] || myNumber[0] == myNumber[3] || myNumber[1] == myNumber[2] || myNumber[1] == myNumber[3] || myNumber[2] == myNumber[3])
                {
                    myNumber[i] = rnd.Next(0, 10);
                    i++;
                }
            }
            Console.WriteLine("Enter four-digit number whose digits are not repeated and are between 0 and 9. For example : 1234");
            

            while (true)
            {
                string input = Console.ReadLine();
                int[] arr = new int [4];
                for (int i = 0; i < 4; i++)
                {
                    arr[i] = int.Parse(input[i].ToString());
                }
                int cows = 0;
                int bulls = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    for (int j = 0; j < input.Length; j++)
                    {
                        if (arr[i] == myNumber[j]&&i==j)
                        {
                            bulls++;
                        }
                        if (arr[i] == myNumber[j]&&i!=j)
                        {
                            cows++;
                        }
                    }
                }
                Console.WriteLine("You have {0} cows and {1} bulls",cows,bulls);
                if (bulls==4)
                {
                    break;
                }
            }
            Console.WriteLine("GG !!!");
            Console.ReadLine();
        }
    }
}
