using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int hourglassSize = 5;
            recursiveClock(hourglassSize, 0, 0);
            Console.ReadLine(); 
            

        }


        public static void recursiveClock(int i_hourglassSize, int i_rowIndex, int i_columnIndex)
        {
            if (i_rowIndex == i_columnIndex ||
                i_rowIndex + i_columnIndex + 1 == i_hourglassSize ||
                (i_rowIndex<i_columnIndex && i_rowIndex + i_columnIndex + 1 < i_hourglassSize) ||
                (i_rowIndex > i_columnIndex && i_rowIndex + i_columnIndex + 1 > i_hourglassSize))
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }
            if (i_columnIndex+1  < i_hourglassSize)
            {
                recursiveClock(i_hourglassSize, i_rowIndex, ++i_columnIndex);
            }
            else if (i_rowIndex+1 < i_hourglassSize)
            {
                Console.Write("\n");
                recursiveClock(i_hourglassSize, ++i_rowIndex, 0);
            }
        }
    }
}
