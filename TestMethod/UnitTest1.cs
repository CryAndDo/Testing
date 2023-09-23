namespace TestMethod
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodEquation()
        {
            MyClass myClass = new MyClass();
            Assert.AreEqual(myClass.Equation(2, -5, 3), true);
            Assert.AreEqual(myClass.Equation(-1, 1, -9), false);
            Assert.AreEqual(myClass.Equation(1, -6, 9), true);
            Assert.AreEqual(myClass.Equation(3, -4, 2), false);
            Assert.AreEqual(myClass.Equation(2, 2, 8), false);
        }
    }
}