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
            var result = new RandomProblems().DistinctElements(3,"1,2,3,3,4,4,5,5,6,6");
            Assert.AreEqual(result,4);           
            
        }
    }
}
