using Microsoft.VisualStudio.TestTools.UnitTesting;
using Obligatorisk_Opgave_3_semester;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;

namespace Obligatorisk_Opgave_3_semester.Tests
{
    [TestClass()]
    public class CarTests
    {
        [TestMethod()]
        public void CarTestLicenseplate()
        {
            Car car = new Car(1, "Audi", 1500, "BB12345");
            car.Licenseplate = "BB12345";
            Assert.AreEqual("BB12345", car.Licenseplate);
            car.Licenseplate = "BB";
            Assert.AreEqual("BB", car.Licenseplate);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => car.Licenseplate = "12345678");
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => car.Licenseplate = "1");

        }

        [TestMethod()]
        public void CarTestModel()
        {
            Car car = new Car(2, "AstonMartin", 2000, "BB54321");
            car.Model = "AstonMartin";
            Assert.AreEqual("AstonMartin", car.Model);

            car.Model = "BMWS";
            Assert.AreEqual("BMWS", car.Model);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => car.Model = "123");


        }

        [TestMethod()]

        public void CarTestPrice()
        {
            Car car = new Car(3, "mazda", 3000, "CC12345");
            car.Price = 3000;
            Assert.AreEqual(3000, car.Price);

            car.Price = 0;
            Assert.AreEqual(0, car.Price);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => car.Price = -1);
        }

        [TestMethod()]

        public void CarTestId()
        {
            Car car = new Car(4, "valvo", 4000, "DD12345");
            Assert.IsInstanceOfType(car.Id, typeof(int));

        }

    }
}
