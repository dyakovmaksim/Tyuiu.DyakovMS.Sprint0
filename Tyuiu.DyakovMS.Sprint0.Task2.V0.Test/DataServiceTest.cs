using Tyuiu.DyakovMS.Sprint0.Task2.V0.Lib;
namespace Tyuiu.DyakovMS.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Максим";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Максим", res);
        }
    }
}