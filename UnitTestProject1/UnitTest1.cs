using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 500;
            int b = 60;
            int r = Lab2.Program.Check1(a, b);
            Assert.AreEqual(8, r);
        }
    }
}
