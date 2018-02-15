using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ECS.Legacy.Test.Unit
{
    [TestFixture]
    public class HeaterUnitTest
    {
        [Test]
        public void runSelfTest_returnsTrue()
        {
            var uut = new Heater();
            Assert.That(uut.RunSelfTest(), Is.True);
        }

        [Test]
        public void runSelfTest_returnsTrue()
        {
            var uut = new Heater();
            Assert.That(uut.RunSelfTest(), Is.True);
        }

    }
}
