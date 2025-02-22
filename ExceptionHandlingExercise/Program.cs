﻿using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------------------------------------------
            // DONE - First create an char[], it must contain 6 numbers and 3 letters - name it arr
            // DONE - Create a list called numbers that will hold integers
            // DONE - Create an string variable with an empty string initializer - name it str

            // TODOusing a foreach loop, attempt to parse the elements in your char[] with int.Parse()
            // and Exceptions will be thrown 
            // Below we will set this up 
            // ------------------------------------------------------------------------------
            var arr = new char[] { '1', '2', '3', '4', '5', '6', 'A', 'B', 'C' };
            var numbers = new List<int>();
            var str = "";



            //TODO START HERE:

            // Make a foreach loop to iterate through your character array
            foreach (var item in arr)
            {
                // Now create a try catch
                try
                {
                    str = item.ToString();
                    var number = int.Parse(str);
                    numbers.Add(number);
                }catch(Exception E)
                {
                    Console.WriteLine($"Unable to Parse '{item}'");
                    //character will be the name of each item in your collection
                }
            }

            // Inside your try block
            // DONE - set your string variable to each array element in your char[] to .ToString()
            // DONE - Now, using int.Parse, parse your string variable and store in an int variable
            // DONE - Then add each int to your list

            // catch your Exception:
            // in the scope of your catch you can use the following, 

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
