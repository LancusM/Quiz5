using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Prompts user to enter string
            Console.WriteLine("CHECK DUPLICATE:");
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            input = input.ToLower();

            //Turns user string into usable array to sort letters
            char[] inputArray = input.ToCharArray();

            
            //foreach sorts through Array, selects each character
            foreach (char c in inputArray)
            {
                
                // I know the code past this point is incorrect, but I couldn't remember how to sort the characters correctly in time.
                
                if (c == inputArray[0])

                for (int i = 0; i < inputArray.Length; i++)
                {
                    Console.WriteLine(i);
                }

                Console.WriteLine(c);


            }


            






            Console.ReadLine();
        }
    }
}
