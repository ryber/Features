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
    }
}
