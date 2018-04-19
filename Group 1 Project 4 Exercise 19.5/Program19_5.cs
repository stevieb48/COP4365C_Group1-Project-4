using System;
using System.Collections;

namespace Group_1_Project_4_Exercise_19._5
{
    class Program19_5
    {
        static void Main(string[] args)
        {
            bool isPalindrome = false;
            
            //Create lowercase letter array for comparison
            char[] az = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            //Create stack
            Stack stack = new Stack();

            //setup char arrays and array lists to hold strings
            char[] inputString;
            ArrayList cleanString = new ArrayList();
            ArrayList reversedString = new ArrayList();

            //prompt user
            Console.WriteLine("Enter any string and this program will tell you if it is a palindrome!");

            //gets user input and forces it into lowercase
            inputString = Console.ReadLine().ToLower().ToCharArray();

            //clean string of spaces and punctuation
            foreach (char c in inputString)
            {
                //checks to see if current character is on a list of lowercase letters
                for (int i = 0; i < az.Length; i++){
                    if (c == az[i])     //if the character is on the list, put it in the clean array. Otherwise, ignore it
                        cleanString.Add(c);
                }
            }

            //print clean string
            Console.WriteLine("\nEntered string without capitals, spaces, or punctuation");
            foreach(char c in cleanString)
            {
                Console.Write(c);
            }

            //push clean string onto the stack
            foreach(char c in cleanString)
            {
                stack.Push(c);
            }

            //pop characters off stack to create a reversed string
            while (stack.Count != 0)
            {
                reversedString.Add(stack.Pop());
            }

            //print reversed string
            Console.WriteLine("\n\nReversed clean string");
            foreach (char c in reversedString)
            {
                Console.Write(c);
            }

            //compare clean string and reversed string to see if they're equal
            for(int i = 0; i < cleanString.Count; i++)
            {
                if(!cleanString[i].Equals(reversedString[i]))
                {
                    isPalindrome = false; //at the first instance of two unequal characters, break the loop
                    break;
                } else
                {
                    //if loop does not break, the strings are equal
                    isPalindrome = true;
                }
                
            }

            //print result of comparison
            if (isPalindrome)
            {
                Console.WriteLine("\n\nThe string is a palindrome!");
            } else
            {
                Console.WriteLine("\n\nThe string is not a palindrome!");
            }

            //hold console open
            Console.ReadKey();

        }
    }
}
