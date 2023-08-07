using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_01
{
    class Program
    {
        static int s_numberOfOnes = 0;
        static int s_numberOfZeros = 0;

        static void Main(string[] args)
        {
   
            int firstInputNumber = convertBinaryNumberInStringToDecimalInt(GetValidInputNumber());
            int secondInputyNumber = convertBinaryNumberInStringToDecimalInt(GetValidInputNumber());
            int thirdInputNumber = convertBinaryNumberInStringToDecimalInt(GetValidInputNumber());
            
            Console.WriteLine(string.Format("The numbers are:\nfirst number: {0}\nsecond number: {1}\nthird number: {2}",
                firstInputNumber, secondInputyNumber, thirdInputNumber));
            Console.WriteLine(string.Format("The average number of zero in the binary numbers is: {0}",s_numberOfZeros / 3));
            Console.WriteLine(string.Format("The average number of one in the binary numbers is: {0}", s_numberOfOnes / 3));

            int NumberOfInputsThatArePowerOfTwo = 0;
            if (isTheNumberIsPowerOfTwo(firstInputNumber))
                NumberOfInputsThatArePowerOfTwo++;
            if (isTheNumberIsPowerOfTwo(secondInputyNumber))
                NumberOfInputsThatArePowerOfTwo++;
            if (isTheNumberIsPowerOfTwo(thirdInputNumber))
                NumberOfInputsThatArePowerOfTwo++;
            Console.WriteLine(string.Format("The number of inputs that are power of 2 is: {0}",NumberOfInputsThatArePowerOfTwo));    
            Console.WriteLine(string.Format("The biggest number is: {0}", SortTheNumbersByValue(firstInputNumber, secondInputyNumber, thirdInputNumber)[2]));
            Console.WriteLine(string.Format("The smallest number is: {0}", SortTheNumbersByValue(firstInputNumber, secondInputyNumber, thirdInputNumber)[0]));
            Console.ReadLine();



        }

        public static string GetValidInputNumber()
        {
            Console.WriteLine("Enter binary numbers with 7 digits:");
            string inputNumber = Console.ReadLine();
            bool inputIsValid = checkInuptValidity(inputNumber);
            while (!inputIsValid)
            {
                Console.WriteLine("The number you entered is not a 7 digitis binary number, plese try again.");
                Console.WriteLine("Enter binary numbers with 7 digits:");
                inputNumber = Console.ReadLine();

                inputIsValid = checkInuptValidity(inputNumber);
            }
            return inputNumber;
        }

        public static bool checkInuptValidity(string i_InputNumber)
        {
            bool inputIsValid = true;
            if (i_InputNumber.Length != 7)
            {
                Console.WriteLine("The number you entered is not a 7 digitis");
                inputIsValid = false;
            }
            else
            {
                for (int i = 0; i < i_InputNumber.Length; i++)
                {
                    if (!i_InputNumber[i].Equals('0'))
                    {
                        if (!i_InputNumber[i].Equals('1'))
                        {
                            inputIsValid = false;
                        }
                        else
                        {
                           s_numberOfOnes++;
                        }
                    }
                    else
                    {
                        s_numberOfZeros++;
                    }
                }
            }
            return inputIsValid;
        }

        public static int convertBinaryNumberInStringToDecimalInt(string i_InputNumberInString)
        {
            double decimalNumber = 0;
            double powerToMultiplyIn = 0.0;
            for (int i = i_InputNumberInString.Length - 1; i >= 0; i--)
            {
                decimalNumber += int.Parse(i_InputNumberInString[i].ToString()) * (Math.Pow(2.0, powerToMultiplyIn));
                powerToMultiplyIn++;
            }
            return (int)decimalNumber;
        }

        public static bool isTheNumberIsPowerOfTwo(int i_InputNumber)
        {
            bool theNumberIsPowerOfTwo = false;
            int intResultOflogTwoToTheInputNumber = (int)Math.Log(i_InputNumber, 2);
            if (intResultOflogTwoToTheInputNumber == Math.Log(i_InputNumber, 2))
                theNumberIsPowerOfTwo = true;
            return theNumberIsPowerOfTwo;
        }

        public static bool isTheNumberIsAscendingSeries(int i_InputNumber)
        {
            bool isAscendingSeries = true;
            int mostRightDigit;
            while (i_InputNumber > 0)
            {
                mostRightDigit = i_InputNumber % 10;
                if (mostRightDigit > ((i_InputNumber / 10) % 10))
                {
                    i_InputNumber /= 10;
                }
                else
                {
                    isAscendingSeries = false;
                    i_InputNumber = 0;
                }
            }
            return isAscendingSeries;
        }

        public static int[] SortTheNumbersByValue(int i_firstInputNumber, int i_secondInputNumber, int i_thirdInputNumber)
        {
            int[] arrOfNumbers = new int[3];
            arrOfNumbers[0] = i_firstInputNumber;
            arrOfNumbers[1] = i_secondInputNumber;
            arrOfNumbers[2] = i_thirdInputNumber;
            Array.Sort(arrOfNumbers);
            return arrOfNumbers;
        }



    }
}
