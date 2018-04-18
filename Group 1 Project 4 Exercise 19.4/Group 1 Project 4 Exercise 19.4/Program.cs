using System;
using System.Collections;

namespace Group_1_Project_4_Exercise_19._4
{
    public class StackExercise
    {
        public static void Main(string[] args)
        {
            //create stack
            Stack stack = new Stack();

            //create character array to hold string
            char[] textLine;

            //tell user what program does
            Console.WriteLine("Enter any string and this program will reverse it!");

            //read in user input
            textLine = Console.ReadLine().ToCharArray();

            //add user input to stack
            foreach (char c in textLine)
            {
                stack.Push(c);
            }

            //confirm user entry
            Console.WriteLine("\nYou entered: ");

            //show user what they entered
            foreach (char c in textLine)
            {
                Console.Write(c);
            }

            
            Console.WriteLine("\n\nNow here is the statement reversed!");

            //reverse the user's statement by popping off of the top of the stack.
            while (stack.Count != 0)
            {
                Console.Write(stack.Pop());
            }

            //holds the console open so it can be read until a key is pressed
            Console.ReadKey();
        }
    }
}