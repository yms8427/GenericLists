using BilgeAdam.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilgeAdam.Unit.Tests
{
    [TestClass]
    public class CustomSortedListFixture
    {
        CustomSortedList Sut = new CustomSortedList();

        [TestMethod]
        public void EmptyList_Returns_0_Items()
        {
            var count = Sut.GetItemCount();
            Assert.AreEqual(0, count);
        }

        [TestMethod]
        public void AddItemToList()
        {
            Sut.Add("go", "gitmek");
            Sut.Add("come", "gelmek");
            Sut.Add("sit", "oturmak");
            Sut.Add("accept", "kabul etmek");
            Sut.Add("visit", "ziyaret etmek");
            Assert.AreEqual(5, Sut.GetItemCount());
            Assert.AreEqual("kabul etmek", Sut.GetItemAt(0));
        }
    }
}
