using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using C_6_base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLINQer()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 15, 12 }; // sum = 42, middle = 42/7 = 6, > 6: 15, 12
            IEnumerable<int> bigger_than_middle = YourTaskHere.LINQer(numbers);
            IEnumerator<int> answer = bigger_than_middle.GetEnumerator();
            Assert.AreEqual(answer.Current, 0);
            answer.MoveNext();
            Assert.AreEqual(answer.Current, 15);
            answer.MoveNext();
            Assert.AreEqual(answer.Current, 12);
            answer.MoveNext();
            Assert.AreEqual(answer.Current, 0);
        }

        [TestMethod]
        public void TestLINQer_2()
        {
            int[] numbers = { 1, 2, 3, 4, 6, 15, 12, -3 }; // sum = 40, middle = 40/8 = 5, > 5: 6, 15, 12
            IEnumerable<int> bigger_than_middle = YourTaskHere.LINQer(numbers);
            IEnumerator<int> answer = bigger_than_middle.GetEnumerator();
            Assert.AreEqual(answer.Current, 0);
            answer.MoveNext();
            Assert.AreEqual(answer.Current, 6);
            answer.MoveNext();
            Assert.AreEqual(answer.Current, 15);
            answer.MoveNext();
            Assert.AreEqual(answer.Current, 12);
            answer.MoveNext();
            Assert.AreEqual(answer.Current, 0);
        }

        [TestMethod]
        public void TestFactorial_1()
        {
            TextReader cin = Console.In;
            int factor = YourTaskHere.factorial(1);
            Assert.AreEqual(factor, 1);
        }

        [TestMethod]
        public void TestFactorial_2()
        {
            TextReader cin = Console.In;
            int factor = YourTaskHere.factorial(2);
            Assert.AreEqual(factor, 2);
        }

        [TestMethod]
        public void TestFactorial_3()
        {
            TextReader cin = Console.In;
            int factor = YourTaskHere.factorial(3);
            Assert.AreEqual(factor, 6);
        }

        [TestMethod]
        public void TestFactorial_7()
        {
            TextReader cin = Console.In;
            int factor = YourTaskHere.factorial(7);
            Assert.AreEqual(factor, 5040);
        }
    }
}
