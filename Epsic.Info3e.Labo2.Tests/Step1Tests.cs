namespace Epsic.Info3e.Labo2.Tests
{
    using System.Collections.Generic;
    using System.Linq;
    using Epsic.Info3e.Labo2.Step1;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Step1Tests
    {
        [TestMethod, TestCategory("Step1")]
        public void CarImplementsIVehicle()
        {
            var result = typeof(Car).GetInterfaces().Contains(typeof(IVehicle));
            Assert.AreEqual(true, result, "Car n'implémente pas IVehicle.");
        }

        [TestMethod, TestCategory("Step1")]
        public void TruckImplementsIVehicle()
        {
            var result = typeof(Truck).GetInterfaces().Contains(typeof(IVehicle));
            Assert.AreEqual(true, result, "Truck n'implémente pas IVehicle.");
        }

        [TestMethod, TestCategory("Step1")]
        public void CarDriveTest()
        {
            var car = new Car();

            var sut = (IVehicle)car;

            Assert.AreEqual("Roule avec 4 roues.", sut.Drive());
        }

        [TestMethod, TestCategory("Step1")]
        public void TruckDriveTest()
        {
            var truck = new Truck();

            var sut = (IVehicle)truck;

            Assert.AreEqual("Roule avec 8 roues.", sut.Drive());
        }

        [TestMethod, TestCategory("Step1")]
        public void VehicleListTests()
        {
            var car = new Car();
            var truck = new Truck();
            var sut = new List<IVehicle> { car, truck };

            Assert.AreEqual(2, sut.Count);
        }
    }
}

