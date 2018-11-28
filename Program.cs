using System;
using System.Collections.Generic;
namespace ListLargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = new List<int>();
            int [] numCollection = new int []
            {
                10,25,66,67,555, 12,1,6767,543
            };

            numList.AddRange(numCollection);
            int largestNum=0;
            foreach(var i in numList)
            {
             if (i> largestNum)   
             {
                 largestNum=i;
                
             }
           
            }
              Console.WriteLine($"The largest number in the list is {largestNum}",largestNum);
              Console.ReadKey();
        }
    }
}
