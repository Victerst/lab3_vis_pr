using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumber.Tests
{
    [TestClass()]
    public class RomanNumberTests
    {
        [TestMethod()]
        public void RomanNumberTest()
        {
            Assert.ThrowsException<RomanNumberException>(() => new RomanNumber(0));
        }


        [TestMethod()]
        public void RomanNumberSum1Test()
        {
            RomanNumber num1 = new(10), num2 = new(4);
            string result = (num1 + num2).ToString();
            string expected = "XIV";

            Assert.AreEqual(expected, result);

        }

        [TestMethod()]
        public void RomanNumberSum2Test()
        {
            
            try
            {
                RomanNumber n3 = new RomanNumber(40000);
                RomanNumber n4 = n3 + n3;
                Assert.Fail("Нет исключений");
            }
            catch (Exception expection)
            {
                Assert.IsInstanceOfType(expection, typeof(RomanNumberException));
            }

        }


        [TestMethod()]
        public void RomanNumberSub1Test()
        {
            RomanNumber n1 = new RomanNumber(3);
            RomanNumber n2 = new RomanNumber(1);
            RomanNumber expected = new RomanNumber(2);

            int real = (n1 - n2).CompareTo(expected);

            Assert.AreEqual(0, real);
        }

        [TestMethod()]
        public void RomanNumberMul1Test()
        {
            RomanNumber n1 = new RomanNumber(6);
            RomanNumber n2 = new RomanNumber(5);
            RomanNumber expected = new RomanNumber(30);

            int real = (n1 * n2).CompareTo(expected);

            Assert.AreEqual(0, real);
        }

        [TestMethod()]
        public void RomanNumberMul2Test()
        {

            try
            {
                RomanNumber n3 = new RomanNumber(40000);
                RomanNumber n4 = n3 * n3;
                Assert.Fail("Нет исключений");
            }
            catch (Exception expection)
            {
                Assert.IsInstanceOfType(expection, typeof(RomanNumberException));
            }

        }

        [TestMethod()]
        public void RomanNumberDiv1Test()
        {
            RomanNumber n1 = new RomanNumber(20);
            RomanNumber n2 = new RomanNumber(5);
            RomanNumber expected = new RomanNumber(4);
            int real = (n1 / n2).CompareTo(expected);

            Assert.AreEqual(0, real);
        }


        [TestMethod()]
        public void RomanNumberDiv2Test()
        {
            RomanNumber n1 = new RomanNumber(15);
            RomanNumber n2 = new RomanNumber(16);

            Assert.ThrowsException<RomanNumberException>(() => n1 / n2);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            RomanNumber n1 = new RomanNumber(12);
            string s = n1.ToString();

            Assert.IsTrue(s == "XII");
        }

        [TestMethod()]
        public void CloneTest()
        {
            RomanNumber n1 = new(15);
            RomanNumber n2 = (RomanNumber)n1.Clone();
            string expected = "XV";

            Assert.AreEqual(expected, n2.ToString());
        }

        [TestMethod()]
        public void CompareToTest()
        {
            RomanNumber n1 = new RomanNumber(50);
            RomanNumber n2 = new RomanNumber(10);
            RomanNumber[] massive = { n1, n2 };
            Array.Sort(massive);

            Assert.AreEqual(massive[0], n2);
            Assert.AreEqual(massive[1], n1);
        }
    }
}