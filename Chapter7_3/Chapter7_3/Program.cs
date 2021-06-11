using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Windows.Forms;

namespace Chapter7_3
{
    class Program
    {
        static void Main()
        {
            double[] array1 = new double[] { 1.5, 2.5, 3.5, 4.5, 7.5 }; // compile-time initialization
            double[] array2 = new double[] { 0.4, 0.3, 0.2, 0.1, 0.7 }; //  compile-time initialization
            double[] array3 = new double[1];
            int i = 0;
            int j = 0;

            double sum = 0;
            for (i = 0; i < array1.Length; i++, j++) 
            {
                sum += array1[i] * array2[j];
            }

            array3[0] = sum;



            string ab = "Array 1: " +"\n";

            foreach (double a in array1) 
            {
                ab += Convert.ToString(a) + "\t" ;
            }

            string ac = ab + "\n" + "Array 2: " + "\n";

            foreach (double a in array2)
            {
                ac += Convert.ToString(a) + "\n" ;
            }

            string ad = ac + "Array 3: " + "\n";

            foreach (double a in array3)
            {
                ad += Convert.ToString(a) + "\t";
            }



            MessageBox.Show(ad,"Array",MessageBoxButtons.OK,MessageBoxIcon.Information);






        }
    }
}
