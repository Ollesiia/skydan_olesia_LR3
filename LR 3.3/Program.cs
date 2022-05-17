using System;
using System.Collections.Generic;
using System.Linq;

namespace Laba_3._3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] scores = { 3,6,12,567, 456, 569, 35, 0};
            foreach (var ig in scores)
            {
                Console.Write(ig + " ");
            }


            IEnumerable<int> scoreQuery =
                from score in scores
                where score %2 !=0
                orderby score
                select score;
            


            foreach (int i in scoreQuery)
            {
                Console.Write("\n " + i + " ");
            }
        }

    }
}