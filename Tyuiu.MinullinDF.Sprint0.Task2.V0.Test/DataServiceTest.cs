using Tyuiu.MinullinDF.Sprint0.Task2.V0.Lib;

namespace Tyuiu.MinullinDF.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Динар";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Динар", res);
        }
    }
}
