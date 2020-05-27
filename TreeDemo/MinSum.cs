using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TreeDemo
{
    public class MinSum
    {
        /// <summary>
        /// Reduces the total sum by always returning the smallest possible sum
        /// it would divide the highest value, and reduce it to its ceiling
        /// </summary>
        /// <param name="num"></param>
        /// <param name="k">number of iterations that should be run</param>
        /// <returns></returns>
        public int minSum(List<int> num, int k)
        {
            var maxValueOfN = Math.Pow(10, 5);

            var numArray = num.Where(x => x <= maxValueOfN).ToList();
            LinkedList<int> numLinkedList = new LinkedList<int>(numArray);

            if (numLinkedList.Any())
            {
                for (int i = 1; i <= k; i++)
                {
                    int maxValue = numLinkedList.Max();
                    
                    decimal reducedElem = Math.Ceiling((decimal)maxValue /(decimal)2 );
                    int reducedInt = Decimal.ToInt32(reducedElem);
                   
                    numLinkedList.Remove(maxValue);
                    numLinkedList.AddFirst(reducedInt);
                    
                }

            }
            
            return numLinkedList.Sum();
        }
        
    }
}
