using BilgeAdam.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilgeAdam.Unit.Tests
{
    [TestClass]
    public class CustomStackFixture
    {
        CustomStack Sut = new CustomStack();

        [TestMethod]
        public void EmptyList_Returns_0_Items()
        {
            var count = Sut.GetItemCount();
            Assert.AreEqual(0, count);
        }

        [TestMethod]
        public void AddItemToStack()
        {
            Sut.Add("Can");
            Sut.Add("Sergen");
            Sut.Add("Emre");
            Sut.Add("Hami");
            Sut.Add("Gamze");
            Assert.AreEqual(5, Sut.GetItemCount());
        }

        [TestMethod]
        public void CallFromStack()
        {
            Sut.Add("Can");
            Sut.Add("Sergen");
            Sut.Add("Emre");
            Sut.Add("Hami");
            Sut.Add("Gamze");
            var next1 = Sut.Call();
            var next2 = Sut.Call();
            Assert.AreEqual(3, Sut.GetItemCount());
            Assert.AreEqual("Gamze", next1);
            Assert.AreEqual("Hami", next2);
        }

        [TestMethod]
        public void CheckNextItemAtQueue()
        {
            Sut.Add("Can");
            Sut.Add("Sergen");
            Sut.Add("Emre");
            Sut.Add("Hami");
            Sut.Add("Gamze");
            var next = Sut.Check();
            Assert.AreEqual("Gamze", next);
            Assert.AreEqual(5, Sut.GetItemCount());
        }
    }
}
