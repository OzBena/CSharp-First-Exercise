using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_03
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter hourglassSize size: ");
            int hourglassSize = getVaildHourglassSizekSize(Console.ReadLine());
            Console.WriteLine("\n");
            Ex01_02.Program.recursiveClock(hourglassSize, 0, 0);
            Console.ReadLine();
        }

        public static int getVaildHourglassSizekSize(string i_hourglassSize) 
        {
            bool isHourglassSizeValid = false;
            int hourglassSizeValid = 0;
            while(!isHourglassSizeValid)
            {
                if(int.TryParse(i_hourglassSize, out hourglassSizeValid))
                {
                    if(hourglassSizeValid >= 3)
                    {
                        isHourglassSizeValid = true;
                    }
                    else
                    {
                        Console.Write("The size should be higer then 3, please enter new size: ");
                        i_hourglassSize = Console.ReadLine();
                    }
                }
                else
                {
                    Console.Write("The size should be a number, please try again: ");
                    i_hourglassSize = Console.ReadLine();
                }
                
            }
            return hourglassSizeValid;
        }
    }
}
