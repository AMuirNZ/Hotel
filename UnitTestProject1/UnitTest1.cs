using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hotel;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BlankOrNot()
        {
            Empty myEmpty = new Empty();

            bool Actual = myEmpty.Guests("1", "1", "1", "1");
            Assert.AreEqual(true, Actual);
        }
    }
}
