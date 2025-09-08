using Tyuiu.MinullinDF.Sprint0._2;
namespace Tyuiu.MinullinDF.Sprint0.Task0._1
{
    [TestClass]
    public sealed class TestWork
    {
        [TestMethod]
        public void TestMethodAdd()
        {
            int a = 5; int b = 6;

            int res = ClassWork.Add(a, b);

            Assert.AreEqual(11, res);
        }
    }
}
