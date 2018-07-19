using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibUnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var lib = new NetCoreLibrary.Lib();

            // Acr
            var actual = lib.RtnOK();

            var expected = "OK";

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
