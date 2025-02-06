using SampleTestDemo;
namespace TestMathOP
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Calc mth = new Calc();
            int res = mth.Add(20, 20); 
            Assert.AreEqual(res, 40);
        }
        [TestMethod]
        public void TestMethodSub()
        {
            Calc mth = new Calc();
            int res = mth.Sub(50, 20);
            Assert.AreEqual(res, 30);
        }
        [TestMethod]
        public void TestMethodProd()
        {
            Calc mth = new Calc();
            int res = mth.Mul(50, 40);
            Assert.AreEqual(res, 2000);
        }
    }
}