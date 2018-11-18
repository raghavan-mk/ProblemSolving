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
    }
}
