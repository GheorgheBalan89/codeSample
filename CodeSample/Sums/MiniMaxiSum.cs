using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TreeDemo
{

    /*
     *
     * *
     * From hacker rank: https://www.hackerrank.com/challenges/mini-max-sum/problem
     * *
     * Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly four of the five integers. Then print the respective minimum and maximum values as a single line of two space-separated long integers.

        For example, . Our minimum sum is  and our maximum sum is . We would print

        16 24
        Function Description

        Complete the miniMaxSum function in the editor below. It should print two space-separated integers on one line: the minimum sum and the maximum sum of  of  elements.

        miniMaxSum has the following parameter(s):

        arr: an array of  integers
        Input Format

        A single line of five space-separated integers.

        Constraints


        Output Format

        Print two space-separated long integers denoting the respective minimum and maximum values that can be calculated by summing exactly four of the five integers. (The output can be greater than a 32 bit integer.)
     */
    public class MiniMaxiSum
    {
        public ulong[] miniMaxSum(int[] arr)
        {
            var arrValues = arr.Select(a => Convert.ToUInt64(a));

            if (arr.ToList().Distinct().Count() > 1)
            {
                var maxValue = arrValues.Max();

                var minSum = arrValues.Where(x => x != maxValue).ToList().Aggregate((i1, i2) => (i1 + i2));

                var minValue = arrValues.Min();
                var maxSum = arrValues.Where(y => y != minValue).ToList().Aggregate((i1, i2) => (i1 + i2));

                var returnValues = new List<ulong>() { minSum, maxSum };
                return returnValues.ToArray();
            }
            else
            {
                var minMaxValue = Convert.ToUInt64( arrValues.Skip(1).Select(b => Convert.ToInt64(b)).Sum());

                return new ulong[] { minMaxValue, minMaxValue };
            }
           
        }
    }
}
