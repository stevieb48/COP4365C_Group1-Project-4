using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * This class ...
 *
 * author: Group 1 (Louis Anthony, Tristan Barrett, Timothy Bates, Stephen Bailey)
 * course: COP4365C
 * assignment: Project 4
 * date: 04/17/2018
 * file name: Generic_IsEqualTo.cs
 * version: 1.0
 */
namespace Exercise_20_10
{
    public class CheckIfEqual
    {
        public bool IsEqualTo<T>(T object1, T object2)
        {
            bool IsEqual = false;

            IsEqual = object1.Equals(object2);

            return IsEqual;
        }
    }
}