using BilgeAdam.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace BilgeAdam.Unit.Tests
{
    [TestClass]
    public class CustomListFixture
    {
        CustomList Sut = new CustomList();

        [TestMethod]
        public void EmptyList_Returns_0_Items()
        {
            var count = Sut.GetItemCount();
            Assert.AreEqual(0, count);
        }

        [TestMethod]
        public void CanAddItem_IntoList()
        {
            Sut.Add("Can");
            Sut.Add("Sergen");
            Sut.Add("Emre");
            Assert.AreEqual(3, Sut.GetItemCount());
        }

        [TestMethod]
        public void CanAddBulkItems_IntoList()
        {
            Sut.Add("Hami", "Gamze", "Kerem", "Elif");
            Assert.AreEqual(4, Sut.GetItemCount());
        }

        [TestMethod]
        public void CanRemove_FromList()
        {
            Sut.Add("Hami", "Gamze", "Kerem", "Elif");
            Sut.Remove("Hami");
            Assert.AreEqual(3, Sut.GetItemCount());
        }

        [TestMethod]
        public void CanCheckItem_FromList()
        {
            Sut.Add("Can");
            Sut.Add("Laden");
            Sut.Add("Umut");
            Sut.Add("Halil");
            Assert.IsTrue(Sut.Has("Can"));
            Assert.IsFalse(Sut.Has("Dilara"));
        }

        [TestMethod]
        public void GetsItemsThatContains_A()
        {
            Sut.Add("Can");
            Sut.Add("Laden");
            Sut.Add("Umut");
            Sut.Add("Halil");
            Sut.Add("Sergen");
            Sut.Add("Emre");
            var filteredItems = Sut.FilterByChar('a').ToList();
            Assert.AreEqual(3, filteredItems.Count);
        }
    }
}
