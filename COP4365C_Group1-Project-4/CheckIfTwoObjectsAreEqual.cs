using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * This class uses generics and checks if 2 separate objects are equal to each other
 *
 * author: Group 1 (Louis Anthony, Tristan Barrett, Timothy Bates, Stephen Bailey)
 * course: COP4365C
 * assignment: Project 4
 * date: 04/17/2018
 * file name: CheckIfEqual.cs
 * version: 1.0
 */
namespace Exercise_20_10
{
    public class CheckIfTwoObjectsAreEqual
    {
        public bool IsEqualTo<T>(T object1, T object2)
        {
            bool IsEqual = object1.Equals(object2);

            return IsEqual;
        }
    }
}