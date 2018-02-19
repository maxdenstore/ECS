using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Internal;
using NUnit.Framework;

namespace ECS.Legacy.Test.Unit
{
    [TestFixture]
    class ECSUnitTest
    {
        [Test]
        public void Regulate_HeaterOn_returnsTrue()
        {
            var uut = new FakeECS(10,new TempSensor(), new FakeHeater());

            Assert.That(uut.Regulate() , Is.False); //treshold is 10 but is 25, dont turn on heater
        }

        [Test]
         public void Regulate_heaterOn_returnsFalse()
        {
            var uut = new FakeECS(26,new TempSensor(), new FakeHeater()); // treshold is 26, but is 25, turn on heater

            Assert.That(uut.Regulate() ,Is.True);
        }

        [Test]
        public void setTreshold6_returnsTrshold6()
        {
            var uut = new FakeECS(0,new TempSensor(), new Heater());

            uut.SetThreshold(6);

            Assert.That(uut.GetThreshold(), Is.EqualTo(6));
        }
    }
}
