using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using problemsolving;

namespace tests
{
    [TestClass]
    public class TestCases
    {
        [TestMethod]
        public void StairCaseProblem()
        {
            var result = new Staircase().Solution(4);
            Assert.AreEqual(result,5);           
            
        }

        [TestMethod]
        public void DistinctElements()
        {
            var result = new RandomProblems().DistinctElements(3,10, new int[]{1,2,3,3,4,4,5,5,6,6}.ToList());
            Assert.AreEqual(result,4);           
            
        }
        [TestMethod]
        public void FibI_Test(){
            var r = new RandomProblems().FibI(6);
            Assert.AreEqual(r,5);
        }

        [TestMethod]
        public void PrimFibI_Test(){
            var r = new RandomProblems().PrimFibISum(100,90,100);
            Assert.AreEqual(r,0);
        }

         [TestMethod]         
        public void IfPrime_Test(){
            var r = new RandomProblems().IfPrime(89);
            Assert.IsTrue(r);
        }
    }
}
