using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTwo
{
    class Program
    {
        static void Main(string[] args)


        {

            while (true)
            {


                //general introductory palaver
                Console.WriteLine("Welcome to the Grand Circus\' Room Detail Generator!");
                Console.Write("For what room would you like to know the details? ");
                string name = Console.ReadLine();

                //let's get the na$ty details and make sure they are floating 
                //length fist
                Console.Write($"Enter {name}'s Length: ");
                string inLength = Console.ReadLine();
                float length = 0;
                while (!float.TryParse(inLength, out length))
                {
                    Console.Write("Sorry, that does not appear to be a valid number. Please try again: ");
                    inLength = Console.ReadLine();
                }

                //now width
                Console.Write($"Thank you. Now please enter {name}'s Width: ");
                string inWidth = Console.ReadLine();
                float width = 0;
                while (!float.TryParse(inWidth, out width))
                {
                    Console.Write("Sorry, that does not appear to be a valid number. Please try again: ");
                    inWidth = Console.ReadLine();
                }

                //time for some math
                Console.Clear();

                Console.WriteLine($"The lenth of the {name} is {length}.");
                Console.WriteLine($"The width of the {name} is {width}.");
                Console.WriteLine($"The area is of the  " + length * width);
                Console.WriteLine($"The perimeter of the {name} is " + ((length * 2)+(width * 2)));

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
            

                //section to see if you want to run the program again

                Console.Write("Would you like to try again ? (y / n)");
                if (Console.ReadLine().ToLower() != "y") break;
            }
        }
    }
}
