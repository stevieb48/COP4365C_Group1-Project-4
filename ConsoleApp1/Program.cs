using Exercise_20_10;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * This program ...
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
            CheckIfEqual newCheckIfEqual = new CheckIfEqual();

            //
            int intObject1 = 1;
            int intObject2 = 2;
            int intObject3 = 1;
            int intObject4 = -1;
            int intObject5 = 1;
            int intObject6 = 1;

            //
            Console.WriteLine("\nThis object " + intObject1 + " and this object " + intObject2 + " IsEqualTo should be False");
            Console.WriteLine("the answer is ...... " + newCheckIfEqual.IsEqualTo(intObject1, intObject2));

            //
            Console.WriteLine("\nThis object " + intObject3 + " and this object " + intObject4 + " IsEqualTo should be False");
            Console.WriteLine("the answer is ...... " + newCheckIfEqual.IsEqualTo(intObject3, intObject4));

            //
            Console.WriteLine("\nThis object " + intObject5 + " and this object " + intObject6 + " IsEqualTo should be True");
            Console.WriteLine("the answer is ...... " + newCheckIfEqual.IsEqualTo(intObject5, intObject6));

            //
            string stringObject1 = "";
            string stringObject2 = "a";
            string stringObject3 = "b";
            string stringObject4 = "B";
            string stringObject5 = "c";
            string stringObject6 = "c";

            //
            Console.WriteLine("\nThis object " + stringObject1 + " and this object " + stringObject2 + " IsEqualTo should be False");
            Console.WriteLine("the answer is ...... " + newCheckIfEqual.IsEqualTo(stringObject1, stringObject2));

            //
            Console.WriteLine("\nThis object " + stringObject3 + " and this object " + stringObject4 + " IsEqualTo should be False");
            Console.WriteLine("the answer is ...... " + newCheckIfEqual.IsEqualTo(stringObject3, stringObject4));

            //
            Console.WriteLine("\nThis object " + stringObject5 + " and this object " + stringObject6 + " IsEqualTo should be True");
            Console.WriteLine("the answer is ...... " + newCheckIfEqual.IsEqualTo(stringObject5, stringObject6));

            //
            object object1 = stringObject1;
            object object2 = intObject6;
            object object3 = intObject5;
            object object4 = intObject6;
            object object5 = stringObject5;
            object object6 = stringObject6;

            //
            Console.WriteLine("\nThis object " + object1 + " and this object " + object2 + " IsEqualTo should be False");
            Console.WriteLine("the answer is ...... " + newCheckIfEqual.IsEqualTo(object1, object2));

            //
            Console.WriteLine("\nThis object " + object3 + " and this object " + object4 + " IsEqualTo should be True");
            Console.WriteLine("the answer is ...... " + newCheckIfEqual.IsEqualTo(object3, object4));

            //
            Console.WriteLine("\nThis object " + object5 + " and this object " + object6 + " IsEqualTo should be True");
            Console.WriteLine("the answer is ...... " + newCheckIfEqual.IsEqualTo(object5, object6));

            Console.ReadKey();
        }
    }
}
