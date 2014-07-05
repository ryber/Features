﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Features.Test
{
    [TestFixture]
    public class PercentagePassCheckerTest
    {

        [Test]
        public void WillPassIfPercentIsGreaterThanRandomNumber()
        {
            var pcc = new PercentagePassChecker(100, new MockRandom(99));

            Assert.True(pcc.Check(Feature.Doughnuts));
        }

        [Test]
        public void WillFailIfLessThanRandomNumber()
        {
            var pcc = new PercentagePassChecker(0, new MockRandom(1));

            Assert.False(pcc.Check(Feature.Doughnuts));
        }

        [Test]
        public void OneHundredIsAlwaysTrue()
        {
            var pcc = new PercentagePassChecker(100, new MockRandom(100));

            Assert.True(pcc.Check(Feature.Doughnuts));
        }

        public class MockRandom : Random
        {
            private readonly int _returnValue;

            public MockRandom(int returnValue)
            {
                _returnValue = returnValue;
            }

            public override int Next(int minValue, int maxValue)
            {
                return _returnValue;
            }
        }
    }
}
