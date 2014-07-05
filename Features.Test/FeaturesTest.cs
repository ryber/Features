using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Features.Test
{
    [TestFixture]
    public class FeaturesTest
    {
        [Test]
        public void ByDefaultAnAlwaysFalseEvaluatorIsUsed()
        {
            FeatureCheckFactory.Reset();
            Assert.IsInstanceOf<AlwaysFalseChecker>(FeatureCheckFactory.Checker);
        }

        [Test]
        public void CheckingUsesTheInstance()
        {
            var checker = new MockChecker();
            FeatureCheckFactory.Checker = checker;

            Assert.IsTrue(Feature.Doughnuts.IsEnabled());
            Assert.AreEqual(Feature.Doughnuts, checker.Checked);
        }

        public class MockChecker : FeatureChecker
        {
            public bool check(Feature feature)
            {
                this.Checked = feature;
                return true;
            }

            public Feature Checked { get; private set; }
        }
    }
}
