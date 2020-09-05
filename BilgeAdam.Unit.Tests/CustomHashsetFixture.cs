using BilgeAdam.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace BilgeAdam.Unit.Tests
{
    [TestClass]
    public class CustomHashsetFixture
    {
        CustomHashSet Sut = new CustomHashSet();

        [TestMethod]
        public void EmptyList_Returns_0_Items()
        {
            //var e = 345.GetHashCode();
            //var r = "Can".GetHashCode();
            //var s = Sut.GetHashCode();
            //var g = Guid.NewGuid().GetHashCode();

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
        public void CanAddDuplicatedItems_IntoList()
        {
            Sut.Add("Can");
            Sut.Add("Sergen");
            Sut.Add("Sergen");
            Sut.Add("Emre");
            Sut.Add("Emre");
            Sut.Add("Can");
            Sut.Add("Emre");
            Assert.AreEqual(3, Sut.GetItemCount());
        }

        [TestMethod]
        public void CanAddBulkItems_IntoList()
        {
            Sut.Add("Hami", "Hami", "Gamze", "Gamze", "Kerem", "Elif");
            Assert.AreEqual(4, Sut.GetItemCount());
        }

        [TestMethod]
        public void CanRemove_FromList()
        {
            Sut.Add("Hami", "Gamze", "Gamze", "Kerem", "Elif");
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
    }
}
