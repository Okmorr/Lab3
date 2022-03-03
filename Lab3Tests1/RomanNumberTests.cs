using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Tests
{
    [TestClass()]
    public class RomanNumberTests
    {
        [TestMethod()]
        public void ToStringTest()
        {
            string desired = "X";
            RomanNumber real = new RomanNumber(10);

            Assert.AreEqual(desired, real.ToString());
        }

        [TestMethod()]
        public void ToStringTest1()
        {
            string desired = "CCXL";
            RomanNumber real = new RomanNumber(240);

            Assert.AreEqual(desired, real.ToString());
        }

        [TestMethod()]
        public void CloneTest()
        {
            RomanNumber n_1 = new RomanNumber(10);
            RomanNumber n_2 = (RomanNumber)n_1.Clone();

            Assert.IsTrue(n_1.CompareTo(n_2) == 0);
        }

        [TestMethod()]
        public void CompareToTest()
        {
            int desired = 0;
            RomanNumber n_1 = new RomanNumber(1);
            RomanNumber n_2 = new RomanNumber(1);

            int real = n_1.CompareTo(n_2);

            Assert.AreEqual(desired, real);
        }

        [TestMethod()]
        public void CompareToTest1()
        {
            int desired = 1;
            RomanNumber n_1 = new RomanNumber(2);
            RomanNumber n_2 = new RomanNumber(1);

            int real = n_1.CompareTo(n_2);

            Assert.AreEqual(desired, real);
        }

        [TestMethod()]
        public void CompareToTest2()
        {
            int desired = -1;
            RomanNumber n_1 = new RomanNumber(4);
            RomanNumber n_2 = new RomanNumber(5);

            int real = n_1.CompareTo(n_2);

            Assert.AreEqual(desired, real);
        }

        [TestMethod()]
        public void AddTest()
        {
            RomanNumber n_1 = new RomanNumber(3);
            RomanNumber n_2 = new RomanNumber(2);
            RomanNumber desired = new RomanNumber(5);

            int real = (n_1 + n_2).CompareTo(desired);

            Assert.AreEqual(0, real);
        }

        [TestMethod()]
        public void AddTest1()
        {
            RomanNumber n_1 = new RomanNumber(3);
            RomanNumber n_2 = null;

            Assert.ThrowsException<RomanNumberException>(() => n_1 + n_2);
        }

        [TestMethod()]
        public void SubTest()
        {
            RomanNumber n_1 = new RomanNumber(5);
            RomanNumber n_2 = new RomanNumber(1);
            RomanNumber desired = new RomanNumber(4);

            int real = (n_1 - n_2).CompareTo(desired);

            Assert.AreEqual(0, real);
        }

        [TestMethod()]
        public void SubTest1()
        {
            RomanNumber n_1 = new RomanNumber(5);
            RomanNumber n_2 = null;

            Assert.ThrowsException<RomanNumberException>(() => n_1 - n_2);
        }

        [TestMethod()]
        public void SubTest2()
        {
            RomanNumber n_1 = new RomanNumber(2);
            RomanNumber n_2 = new RomanNumber(5);

            Assert.ThrowsException<RomanNumberException>(() => n_1 - n_2);
        }

        [TestMethod()]
        public void MulTest()
        {
            RomanNumber n_1 = new RomanNumber(2);
            RomanNumber n_2 = new RomanNumber(5);
            RomanNumber desired = new RomanNumber(10);

            int real = (n_1 * n_2).CompareTo(desired);

            Assert.AreEqual(0, real);
        }

        [TestMethod()]
        public void MulTest1()
        {
            RomanNumber n_1 = new RomanNumber(2);
            RomanNumber n_2 = null;

            Assert.ThrowsException<RomanNumberException>(() => n_1 * n_2);
        }

        [TestMethod()]
        public void DivTest()
        {
            RomanNumber n_1 = new RomanNumber(10);
            RomanNumber n_2 = new RomanNumber(2);
            RomanNumber desired = new RomanNumber(5);

            int real = (n_1 / n_2).CompareTo(desired);

            Assert.AreEqual(0, real);
        }

        [TestMethod()]
        public void DivTest1()
        {
            RomanNumber n_1 = new RomanNumber(2);
            RomanNumber n_2 = null;

            Assert.ThrowsException<RomanNumberException>(() => n_1 / n_2);
        }

        [TestMethod()]
        public void DivTest2()
        {
            RomanNumber n_1 = new RomanNumber(10);
            RomanNumber n_2 = new RomanNumber(12);

            Assert.ThrowsException<RomanNumberException>(() => n_1 / n_2);
        }

        [TestMethod()]
        public void RomanNumberTest1()
        {
            Assert.IsNotNull(new RomanNumber(1));
        }
    }
}