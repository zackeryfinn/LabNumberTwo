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

                // James - inLength? I assume this is short for inputLength, in C#
                // we often like to read fleshed out variable names, even if they become
                // lengthy, this makes it easier to read the code at first glance 
                string inLength = Console.ReadLine();

                // James - few things about length here, I see you are doing this because you want
                // to make sure this variable is initialized.  This is actually necessary if you are working
                // with reference types, ie classes(objects).  but because a float is a value type and 
                // we assign it a value later, it's fine just to put 
                //
                // float length;
                //
                // also since you are using TryParse, you notice that this methods second argument is an
                // out value, so with C# 7, you can actually initialize the variable here WITHOUT having to 
                // initialize it on the line before it.  for example.
                //
                // !float.TryParse(inLength, out float length)
                //
                // also you could inline the Console.ReadLine() here as well!
                //
                // !float.TryParse(Console.ReadLine(), out float length)
                //
                // all just food for thought!
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
                // James - Nice use of Console.Clear();
                Console.Clear();

                Console.WriteLine($"The lenth of the {name} is {length}.");
                Console.WriteLine($"The width of the {name} is {width}.");

                // James - so I think you forgot to put the {name} in this WriteLine ;)
                Console.WriteLine($"The area is of the  " + length * width);
                Console.WriteLine($"The perimeter of the {name} is " + ((length * 2)+(width * 2)));

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
            

                //section to see if you want to run the program again

                Console.Write("Would you like to try again ? (y / n)");
                // Good use of Tolower() ! however when comparing strings I highly 
                // recommend using the Equal method on strings. for example..
                //
                // if (Console.ReadLine().Equals("y", StringComparison.OrdinalIgnoreCase))
                // or
                // if (string.Equals(Console.ReadLine(), "y", StringComparison.OrdinalIgnoreCase)) 
                //
                // you could also consider using Console.ReadKey()
                if (Console.ReadLine().ToLower() != "y") break;
            }
        }
    }
}
