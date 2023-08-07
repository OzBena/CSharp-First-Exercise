using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_04
{
    class Program
    {
        static bool s_isTheInputStringIsNumber = false;
        public static void Main(string[] args)
        {
             Console.Write("Enter 8 letters or numbers string : ");
             string inputString = getValidityInput(Console.ReadLine());
             if(isTheStringIsPalindrome(inputString, 0 , inputString.Length-1))
             {
                 Console.WriteLine("This string is a Palindrome");
             }
             else
             {
                 Console.WriteLine("This string is NOT a Palindrome");
             }
             if(s_isTheInputStringIsNumber)
             {
                 if (int.Parse(inputString)%4 == 0)
                 {
                     Console.WriteLine("This number divide by 4");

                 }
                 else
                 {
                     Console.WriteLine("This number NOT divide by 4");

                 }
             }
             else
             {
                 Console.WriteLine(string.Format("In this string there is a {0} uppercase letters",numberOfUppercaseLetters(inputString)));

             }
            


            Console.ReadLine();
        }

        public static int numberOfUppercaseLetters(string i_inputString)
        {
            int mumberOfUppercases = 0;
            for (int i = 0; i< i_inputString.Length;i++)
            {
                if (i_inputString[i] <='Z')
                {
                    mumberOfUppercases++;
                }
            }
            return mumberOfUppercases;
        }

        public static bool isTheStringIsPalindrome(string i_inputString, int i_leftSideToChek, int i_rightSideToChek)
        {
            if (i_leftSideToChek == i_rightSideToChek || i_rightSideToChek<i_leftSideToChek)
            {
                return true;
            }
            else if (i_inputString[i_leftSideToChek] != i_inputString[i_rightSideToChek])
            {
                return false; 
            }
            else
            {
                return (isTheStringIsPalindrome(i_inputString, ++i_leftSideToChek, --i_rightSideToChek));        
            }
        }

        public static string getValidityInput(string i_inputString)
        {
            bool isInputIsValid = false;
            while (!isInputIsValid)
            {
                if(i_inputString.Length == 8)
                {
                    int parseResult;
                    if (int.TryParse(i_inputString,out parseResult))
                    {
                        s_isTheInputStringIsNumber = true;
                        isInputIsValid = true;
                    }
                    else
                    {
                        for (int i = 0; i < i_inputString.Length; i++)
                        {
                            if (!(i_inputString[i] >= 'a' && i_inputString[i] <= 'z') &&
                                !(i_inputString[i] >= 'A' && i_inputString[i] <= 'Z'))
                            {
                                Console.Write("The string can be only letters or only numbers, please enter a new string: ");
                                i_inputString = Console.ReadLine();
                                break;
                            }
                            if (i + 1 == i_inputString.Length)
                            {
                                isInputIsValid = true;
                            }
                        }  
                    }
                }
                else
                {
                    Console.Write("This string is not in length of 8, please enter a new string: ");
                    i_inputString = Console.ReadLine(); 

                }
            }
            return i_inputString;
        }
    }
}
