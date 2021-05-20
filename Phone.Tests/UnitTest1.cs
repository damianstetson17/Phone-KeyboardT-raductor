using Microsoft.VisualStudio.TestTools.UnitTesting;
using Phone.Controllers;

namespace Phone.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void HiTest()
        {
            TextController textController = new TextController();
            string result = textController.getNumberSecuence("hi");
            string spectedResult = "44 444";
            Assert.AreEqual(spectedResult,result);
        }

        [TestMethod]
        public void YesTest()
        {
            TextController textController = new TextController();
            string result = textController.getNumberSecuence("yes");
            string spectedResult = "999337777";
            Assert.AreEqual(spectedResult,result);
        }

        [TestMethod]
        public void Foo_barTest()
        {
            TextController textController = new TextController();
            string result = textController.getNumberSecuence("foo bar");
            string spectedResult = "333666 666022 2777";
            Assert.AreEqual(spectedResult,result);
        }

        [TestMethod]
        public void HelloWorldTest()
        {
            TextController textController = new TextController();
            string result = textController.getNumberSecuence("hello world");
            string spectedResult = "4433555 555666096667775553";
            Assert.AreEqual(spectedResult,result);
        }
    }
}
