using BilgeAdam.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace BilgeAdam.Unit.Tests
{
    [TestClass]
    public class CustomDictoryFixture
    {
        CustomDictionary Sut = new CustomDictionary();

        [TestMethod]
        public void EmptyDictionary_Returns_0_Item()
        {
            var count = Sut.GetItemCount();
            Assert.AreEqual(0, count);
        }

        [TestMethod]
        public void CanAddItem_IntoDictionary()
        {
            Sut.Add("go", "gitmek");
            Sut.Add("come", "gelmek");
            Sut.Add("sit", "oturmak");
            Assert.AreEqual(3, Sut.GetItemCount());
        }


        [TestMethod]
        public void CanRemove_FromList()
        {
            Sut.Add("go", "gitmek");
            Sut.Add("come", "gelmek");
            Sut.Add("sit", "oturmak");
            Sut.Remove("come");
            Assert.AreEqual(2, Sut.GetItemCount());
        }

        [TestMethod]
        public void GetTranslation()
        {
            Sut.Add("go", "gitmek");
            Sut.Add("come", "gelmek");
            Sut.Add("sit", "oturmak");

            var translation = Sut.TranslateToTurkish("go");
            Assert.AreEqual("gitmek", translation);
        }

        [TestMethod]
        public void GetTranslationV2()
        {
            Sut.Add("go", "gitmek");
            Sut.Add("come", "gelmek");
            Sut.Add("sit", "oturmak");

            var translation = Sut.TranslateToEnglish("oturmak");
            Assert.AreEqual("sit", translation);
        }

        [TestMethod]
        public void CanCheckItem_FromList()
        {
            Sut.Add("look", "bakmak");
            Sut.Add("write", "yazmak");
            Sut.Add("read", "okumak");
            Sut.Add("watch", "izlemek");
            Assert.IsTrue(Sut.Has("look"));
            Assert.IsFalse(Sut.Has("run"));
        }
    }
}
