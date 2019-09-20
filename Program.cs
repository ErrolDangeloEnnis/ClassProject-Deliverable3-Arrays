using System;

namespace ClassProject_Deliverable3_Arrays

    /*
     * Author: Errol Ennis
     * Date: September 19, 2019
     * Comments: Array that displays each of its 25 elements
     */
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is the manually populated array
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };

            Console.WriteLine("Below is an example of a manually populated array:");
            Console.WriteLine("The array contains 25 elements");
            Console.WriteLine("_______________________________________________________");
            Console.WriteLine("");

            foreach (int i in numbers)
            {
                Console.Write("Element Value =" + i + Environment.NewLine);
            }//end of foreach

            Console.WriteLine("");
            Console.WriteLine("_______________________________________________________");

            Console.WriteLine("Press any key to exit the program...");
            Console.ReadKey(true);
        }
    }
}
