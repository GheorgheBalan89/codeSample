using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace TreeDemo.Tests
{
    class MinSumTests
    {
        [Test]
        public void TestOne()
        {
            var testList = new List<int>(){2};
            var sum = new MinSum().minSum(testList, 1);
            Assert.AreEqual(1, sum);
        }

        [Test]
        public void TestTwo()
        {
            var testList = new List<int>() { 2, 3 };
            var sum = new MinSum().minSum(testList, 1);
            Assert.AreEqual(4, sum);
        }

        [Test]
        public void TestThree()
        {
            var testList = new List<int>() { 2, 3, 4, 5, 6 };
            var sum = new MinSum().minSum(testList, 1);
            Assert.AreEqual(17, sum);
        }


    }
}
