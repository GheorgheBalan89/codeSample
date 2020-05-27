using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace TreeDemo.Tests
{
    public class MiniMaxiSumTests
    {
        [Test]
        public void TestOne()
        {
            var input = new int[] {1, 2, 3, 4, 5};
            var sum = new MiniMaxiSum().miniMaxSum(input);
            Assert.AreEqual(sum[0], 10);
            Assert.AreEqual(sum[1], 14);
        }

        [Test]
        public void TestTwo()
        {
            var input = new int[] {7, 69, 2, 221, 8974 };
            var sum = new MiniMaxiSum().miniMaxSum(input);
            Assert.AreEqual(sum[0], 299);
            Assert.AreEqual(sum[1], 9271);
        }

        [Test]
        public void TestThree()
        {
            var input = new int[] { 256741038, 623958417, 467905213, 714532089, 938071625 };
            var sum = new MiniMaxiSum().miniMaxSum(input);
            Assert.AreEqual(sum[0], 2063136757);
            Assert.AreEqual(sum[1], 2744467344);
        }

        [Test]
        public void TestFour()
        {
            var input = new int[] { 5, 5, 5, 5, 5 };
            var sum = new MiniMaxiSum().miniMaxSum(input);
            Assert.AreEqual(sum[0], 20);
            Assert.AreEqual(sum[1], 20);
        }
    }
}
