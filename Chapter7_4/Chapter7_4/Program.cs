using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Chapter7_4
{
    class Program
    {
        static void Main()
        {
            int[] a = new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            string inValue;
            int acceptedValue;
            int invalidCount = 0;
            string moreEntry="";
            int validCount = 0;

            do
            {
                Write("Enter the value: ");
                inValue = ReadLine();

                if (int.TryParse(inValue, out acceptedValue) == false)
                {
                    WriteLine("Invalid entry, data type is wrong.");
                    invalidCount++;
                }
                else
                    if (acceptedValue < 0 || acceptedValue > 10) 
                    {
                    WriteLine("Data is out of range, accepted only 0-10. ");
                    invalidCount++;
                    }
                else
                    {
                    validCount++;
                    switch (acceptedValue)
                    {

                        case 0:
                            a[0] = a[0] + 1;
                            break;

                        case 1:
                            a[1] = a[1] + 1;
                            break;

                        case 2:
                            a[2] = a[2] + 1;
                            break;

                        case 3:
                            a[3] = a[3] + 1;
                            break;

                        case 4:
                            a[4] = a[4] + 1;
                            break;

                        case 5:
                            a[5] = a[5] + 1;
                            break;

                        case 6:
                            a[6] = a[6] + 1;
                            break;

                        case 7:
                            a[7] = a[7] + 1;
                            break;

                        case 8:
                            a[8] = a[8] + 1;
                            break;

                        case 9:
                            a[9] = a[9] + 1;
                            break;

                        case 10:
                            a[10] = a[10] + 1;
                            break;
                    }
                }
                               

                WriteLine("Do you want another entry? <Y or N>");
                moreEntry = ReadLine();
            }
            while (moreEntry == "Y" || moreEntry == "y");

            Clear();

            WriteLine("Entry\t\tNumber of times inputted");
            for (int i = 0; i<11; i++) 
            {
                if (a[i] > 0)
                {
                    WriteLine(i + "\t\t" + a[i]);
                }
                            
            }

            WriteLine("\nSum of Valid entries: " + validCount);
            WriteLine("Sum of Invalid entries: " + invalidCount);

            ReadKey();

        }
    }
}
