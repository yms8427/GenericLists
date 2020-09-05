using BilgeAdam.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilgeAdam.Unit.Tests
{
    [TestClass]
    public class CustomQueueFixture
    {
        CustomQueue Sut = new CustomQueue();

        [TestMethod]
        public void EmptyList_Returns_0_Items()
        {
            var count = Sut.GetItemCount();
            Assert.AreEqual(0, count);
        }

        [TestMethod]
        public void AddItemToQueue()
        {
            Sut.Add("Can");
            Sut.Add("Sergen");
            Sut.Add("Emre");
            Sut.Add("Hami");
            Sut.Add("Gamze");
            Assert.AreEqual(5, Sut.GetItemCount());
        }

        [TestMethod]
        public void CallFromQueue()
        {
            Sut.Add("Can");
            Sut.Add("Sergen");
            Sut.Add("Emre");
            Sut.Add("Hami");
            Sut.Add("Gamze");
            var next1 = Sut.Call();
            var next2 = Sut.Call();
            Assert.AreEqual(3, Sut.GetItemCount());
            Assert.AreEqual("Can", next1);
            Assert.AreEqual("Sergen", next2);
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
            Assert.AreEqual("Can", next);
            Assert.AreEqual(5, Sut.GetItemCount());
        }
    }
}
