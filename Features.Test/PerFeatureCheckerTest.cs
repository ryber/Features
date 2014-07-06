using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Features.Test
{
    [TestFixture]
    public class PerFeatureCheckerTest
    {
        private PerFeatureChecker _pfc;

        [SetUp]
        public void SetUp()
        {
            _pfc = new PerFeatureChecker();
        }

        [Test]
        public void PerFeatureCheckerHasACheckerForEachFeature()
        {
            var doughnutchecker = new MockChecker();
            var timeChecker = new MockChecker();

            _pfc.Add(Feature.Doughnuts, doughnutchecker);
            _pfc.Add(Feature.TimeTravel, timeChecker);

            _pfc.Check(Feature.Doughnuts, null);
            Assert.AreEqual(Feature.Doughnuts, doughnutchecker.Checked);
            Assert.AreEqual(1, doughnutchecker.CheckCount);
            Assert.AreEqual(0, timeChecker.CheckCount);
        }

        [Test]
        public void IfFeatureDoesNotHaveACheckerReturnFalse()
        {
            Assert.False(_pfc.Check(Feature.Doughnuts, null));
        }

        [Test]
        public void TheFirstCheckerThatPassesWins()
        {
            var check1 = new MockChecker(false);
            var check2 = new MockChecker(false);

            _pfc.Add(Feature.Doughnuts, check1);
            _pfc.Add(Feature.Doughnuts, check2);

            Assert.False(_pfc.Check(Feature.Doughnuts, null));

            Assert.AreEqual(Feature.Doughnuts, check1.Checked);
            Assert.AreEqual(Feature.Doughnuts, check2.Checked);
            Assert.AreEqual(1, check1.CheckCount);
            Assert.AreEqual(1, check2.CheckCount);
        }

        [Test]
        public void IfAnyChckerIsTrueThenItsTrue()
        {
            _pfc.Add(Feature.Doughnuts, new MockChecker(false));
            _pfc.Add(Feature.Doughnuts, new MockChecker(true));
            _pfc.Add(Feature.Doughnuts, new MockChecker(false));

            Assert.True(_pfc.Check(Feature.Doughnuts, null));
        }
    }
}
