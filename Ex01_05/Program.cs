using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_05
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Plese enter 6 digit number: ");
            string inputNumber = getValidNumber(Console.ReadLine());

            Console.WriteLine(string.Format("There is a {0} digits that grater then the unit digit", numberOfDigitsThatGraterThenUnitDigits(inputNumber)));
            Console.WriteLine(string.Format("The smallest digit is {0}", getTheSmallestDigit(inputNumber)));
            Console.WriteLine(string.Format("There is a {0} digits that divide by 3", numberOfDigitDivideByThree(inputNumber)));
            Console.WriteLine(string.Format("The average of the digits is: {0}",string.Format("{0:0.00}",avargeOfTheDigits(inputNumber))));
            Console.ReadLine();
        }

        public static double avargeOfTheDigits(String i_inputNumberAsAString)
        {
            double inputNumberAsInt = int.Parse(i_inputNumberAsAString);
            double sumOfDigits = 0;
            while (inputNumberAsInt > 0)
            {
                sumOfDigits += inputNumberAsInt % 10;
                inputNumberAsInt /= 10;
            }
            return sumOfDigits / 6;
        }

        public static int numberOfDigitDivideByThree(String i_inputNumberAsAString)
        {
            int counterOfNumberDivideByTree = 0;
            for (int i = 0; i < i_inputNumberAsAString.Length; i++)
            {
                if (i_inputNumberAsAString[i] == '3' || i_inputNumberAsAString[i] == '6' || i_inputNumberAsAString[i] == '9')
                {
                    counterOfNumberDivideByTree++;
                }
            }
            return counterOfNumberDivideByTree;
        }

        public static char getTheSmallestDigit(String i_inputNumberAsAString)
        {
            char theSmallestDigit = i_inputNumberAsAString[0];

            for (int i = 1; i < i_inputNumberAsAString.Length; i++)
            {
                if (i_inputNumberAsAString[i] < theSmallestDigit)
                {
                    theSmallestDigit = i_inputNumberAsAString[i];
                }
            }
            return theSmallestDigit;
        }

        public static int numberOfDigitsThatGraterThenUnitDigits(String i_inputNumberAsAString)
        {
            char unitDigit = i_inputNumberAsAString[i_inputNumberAsAString.Length - 1];
            int counterOfDigitGraterThenUnitDigit = 0;
            for (int i = 0; i < i_inputNumberAsAString.Length - 1; i++)
            {
                if (i_inputNumberAsAString[i] > unitDigit)
                {
                    counterOfDigitGraterThenUnitDigit++;
                }
            }
            return counterOfDigitGraterThenUnitDigit;
        }

        public static string getValidNumber(string i_inputNumberAsAString)
        {
            bool isInputIsValid = false;
            while (!isInputIsValid)
            {
                if (i_inputNumberAsAString.Length == 6)
                {
                    for (int i = 0; i < i_inputNumberAsAString.Length; i++)
                    {
                        if (!(i_inputNumberAsAString[i] >= '0' && i_inputNumberAsAString[i] <= '9'))
                        {
                            Console.Write("The input need to be only numbers, enter a new number: ");
                            i_inputNumberAsAString = Console.ReadLine();
                            break;
                        }
                        if (i + 1 == i_inputNumberAsAString.Length)
                        {
                            isInputIsValid = true;

                        }
                    }
                }
                else
                {
                    Console.Write("Plese enter a 6 digits number: ");
                    i_inputNumberAsAString = Console.ReadLine();
                }
            }
            return i_inputNumberAsAString;
        }
    }
}