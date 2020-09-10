namespace Epsic.Info3e.Labo2.Tests
{
    using System.Collections.Generic;
    using System.Linq;
    using Epsic.Info3e.Labo2.Step2;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Step2Tests
    {
        [TestMethod, TestCategory("Step2")]
        public void CatInheritsAnimal()
        {
            var result = typeof(Cat).IsSubclassOf(typeof(Animal));
            Assert.AreEqual(true, result, "Cat n'hérite pas d'Animal.");
        }

        [TestMethod, TestCategory("Step2")]
        public void CowInheritsAnimal()
        {
            var result = typeof(Cow).IsSubclassOf(typeof(Animal));
            Assert.AreEqual(true, result, "Cow n'hérite pas d'Animal.");
        }

        [TestMethod, TestCategory("Step2")]
        public void CatEats()
        {
            var sut = new Cat("Domi");

            Assert.AreEqual("Je mange des croquettes.", sut.Eat());
        }

        [TestMethod, TestCategory("Step2")]
        public void CowEats()
        {
            var sut = new Cow("Rose");

            Assert.AreEqual("Je mange du foin.", sut.Eat());
        }

        [TestMethod, TestCategory("Step2")]
        public void CatName()
        {
            var sut = new Cat("Domi");

            Assert.AreEqual("Domi", sut.GetName());
        }

        [TestMethod, TestCategory("Step2")]
        public void CowName()
        {
            var sut = new Cow("Rose");

            Assert.AreEqual("Holy Rose", sut.GetName());
        }
    }
}

