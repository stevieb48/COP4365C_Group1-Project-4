using Exercise_20_10;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * This program tests the classes created for Group Project 4. It uses the class CheckIfTwoObjectsAreEqual
 *
 * author: Group 1 (Louis Anthony, Tristan Barrett, Timothy Bates, Stephen Bailey)
 * course: COP4365C
 * assignment: Project 4
 * date: 04/17/2018
 * file name: Program.cs
 * version: 1.0
 */
namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            //Program19_4 newProgram19_4 = new Program19_4();

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
            
            // main code for testing Exercise_20_10
            // create new CheckIfEqual object
            CheckIfTwoObjectsAreEqual newCheckIfTwoObjectsAreEqual = new CheckIfTwoObjectsAreEqual();

            // create 6 int objects set with various values
            int intObject1 = 1;
            int intObject2 = 2;
            int intObject3 = 1;
            int intObject4 = -1;
            int intObject5 = 1;
            int intObject6 = 1;

            // test int objects
            Console.WriteLine("\nThis object " + intObject1 + " and this object " + intObject2 + " IsEqualTo should be False");
            Console.WriteLine("the answer is ...... " + newCheckIfTwoObjectsAreEqual.IsEqualTo(intObject1, intObject2));

            Console.WriteLine("\nThis object " + intObject3 + " and this object " + intObject4 + " IsEqualTo should be False");
            Console.WriteLine("the answer is ...... " + newCheckIfTwoObjectsAreEqual.IsEqualTo(intObject3, intObject4));

            Console.WriteLine("\nThis object " + intObject5 + " and this object " + intObject6 + " IsEqualTo should be True");
            Console.WriteLine("the answer is ...... " + newCheckIfTwoObjectsAreEqual.IsEqualTo(intObject5, intObject6));

            // create 6 string objects set with various values
            string stringObject1 = "";
            string stringObject2 = "a";
            string stringObject3 = "b";
            string stringObject4 = "B";
            string stringObject5 = "c";
            string stringObject6 = "c";

            // test string objects
            Console.WriteLine("\nThis object " + stringObject1 + " and this object " + stringObject2 + " IsEqualTo should be False");
            Console.WriteLine("the answer is ...... " + newCheckIfTwoObjectsAreEqual.IsEqualTo(stringObject1, stringObject2));

            Console.WriteLine("\nThis object " + stringObject3 + " and this object " + stringObject4 + " IsEqualTo should be False");
            Console.WriteLine("the answer is ...... " + newCheckIfTwoObjectsAreEqual.IsEqualTo(stringObject3, stringObject4));

            Console.WriteLine("\nThis object " + stringObject5 + " and this object " + stringObject6 + " IsEqualTo should be True");
            Console.WriteLine("the answer is ...... " + newCheckIfTwoObjectsAreEqual.IsEqualTo(stringObject5, stringObject6));

            // create 6 objects some set to int objects some set to string objects
            object object1 = stringObject1;
            object object2 = intObject6;
            object object3 = intObject5;
            object object4 = intObject6;
            object object5 = stringObject5;
            object object6 = stringObject6;

            // test various objects some set to int objects some set to string objects
            Console.WriteLine("\nThis object " + object1 + " and this object " + object2 + " IsEqualTo should be False");
            Console.WriteLine("the answer is ...... " + newCheckIfTwoObjectsAreEqual.IsEqualTo(object1, object2));

            Console.WriteLine("\nThis object " + object3 + " and this object " + object4 + " IsEqualTo should be True");
            Console.WriteLine("the answer is ...... " + newCheckIfTwoObjectsAreEqual.IsEqualTo(object3, object4));

            Console.WriteLine("\nThis object " + object5 + " and this object " + object6 + " IsEqualTo should be True");
            Console.WriteLine("the answer is ...... " + newCheckIfTwoObjectsAreEqual.IsEqualTo(object5, object6));

            //holds the console open so it can be read until a key is pressed
            Console.ReadKey();
        }
    }
}