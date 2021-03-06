﻿/*
Author: Bogdan Livadaru 
Date:   10/5/2019
CTEC 135: Microsoft Software Development with C#

<Solution Name>

<Problem description from README.md file. Make sure the comment text is 
reformatted to fit 1-80 column display, with appropriate indentations to 
make it readable>

Example:
Prob 1: Prob 1: Variables and Printing

* region 1: variable declarations

    page 18 in Troelsen shows two different ways to declare int variables. 
    page 71 shows a third way using the "new" keyword.

    In this section declare three different double variables using each of 
    the three type declarations.
...

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region example of a code region
            // some code
            #endregion

            #region another code region
            // some code
            #endregion

            #region variable declarations

            double firstTest = 0;
            System.Double test = 0.0;
            double secondTest = new double();
            #endregion

            #region variable initialization

            bool first = true;
            Console.WriteLine(first);
            byte second = 172;
            Console.WriteLine(second);
            short third = 29_321;
            Console.WriteLine("{0:c}", third);
            int fourth = 2_147_482_648;
            Console.WriteLine(fourth);
            long fifth = 8_777_555_444_333_222_111;
            Console.WriteLine(fifth);
            char sixth = 'a';
            Console.WriteLine(sixth);
            float seventh = 2.441231221312312f;
            Console.WriteLine(seventh);
            double eight = 0.0;
            Console.WriteLine(eight);
            decimal ninth = 3.7m;
            Console.WriteLine(ninth);
            string tenth = "almost";
            Console.WriteLine(tenth);
            Object eleventh = "okay";
            Console.WriteLine(eleventh);



            #endregion

            #region Max/Min values

            Console.WriteLine("The maximum value of a double is: " + Double.MaxValue + " and the smalles value of a double is: " + Double.MinValue);

            #endregion
        }
    }
}
