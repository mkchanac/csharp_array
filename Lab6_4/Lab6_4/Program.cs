using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab6_4
{
    class Program
    {
        static void Main()
        {
            int count = 0;
            string inValue;
            string[] name = new string[10];
            string[] birthday = new string[10];

            for (int i = 0; i < name.Length; i++)
            {
                Write("Enter the Name of User{0}: <ZZZ to exit>", i + 1);
                inValue = ReadLine();
                if (inValue == "ZZZ")
                    break;
                name[i] = inValue;
                Write("Enter the Birthday of User{0}: <dd/mm/yyyy>", i + 1);
                birthday[i] = ReadLine();
                count++;
            }

            for (int i = 0; i < count; i++) 
            {
                WriteLine(name[i]);
            }



            Write("Enter the User Name:");
            inValue = ReadLine();
            do
            {
                int index = Array.IndexOf(name, inValue);

                if (index >= 0)
                {
                    WriteLine("The birthday of {0} is {1}.", name[index], birthday[index]);
                }
                else
                    WriteLine("Error, the name has not been previously entered.");


                Write("Enter the User Name: <ZZZ to exit> ");
                inValue = ReadLine();

            } while (inValue != "ZZZ");

        }
    }
}
