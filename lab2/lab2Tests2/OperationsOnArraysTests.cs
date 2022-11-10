using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace lab2.Tests
{
    [TestClass()]
    public class OperationsOnArraysTests
    {
        [TestMethod()]
        public void GetSumArrayTest()
        {
            double[] array1 = { -3, -2, -1, 0, 1, 2, 3, 4, 5 };
            double[] array2 = { 1,2, 3, 4, 5, 6, 7};
            double[] expect = { -3, -2, -1, 0, 1, 2, 3, 4, 5 , 1, 2, 3, 4, 5, 6, 7 };
            OperationsOnArrays Expect = new OperationsOnArrays(expect);
            OperationsOnArrays Array1 = new OperationsOnArrays(array1);
            OperationsOnArrays Array2 = new OperationsOnArrays(array2);
            OperationsOnArrays Array3 = new OperationsOnArrays();
            Array3 = Array2 + Array1;
            Assert.IsTrue(Array3 == Expect);
        }

        [TestMethod()]
        public void GetProzArrayTest()
        {
            double[] expect = {2, 4, 6, 8, 10};
            OperationsOnArrays Expect = new OperationsOnArrays(expect);
            OperationsOnArrays array = new OperationsOnArrays(new double[] {1, 2, 3, 4, 5 });
            array = array * 2;
            Assert.IsTrue(array == Expect);
        }

        [TestMethod()]
        public void GetDelenieArrayTest1()
        {
            double[] expect = { 2, 4, 6, 8, 10 };
            OperationsOnArrays Expect = new OperationsOnArrays(expect);
            OperationsOnArrays array = new OperationsOnArrays(new double[] { 4, 8, 12, 16, 20 });
            array = array / 2;
            Assert.IsTrue(array == Expect);
        }

        [TestMethod()]
        public void GetDelenieArrayTest2()
        {
            double[] expect = { 2, 4, 6, 8, 10 };
            OperationsOnArrays Expect = new OperationsOnArrays(expect);
            OperationsOnArrays array = new OperationsOnArrays(new double[] { 2, 4, 6, 8, 10 });
            array = array / 0;
            Assert.IsTrue(array == Expect);
        }
    }
}