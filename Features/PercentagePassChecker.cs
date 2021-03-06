﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features
{
    public class PercentagePassChecker : IFeatureChecker
    {
        private readonly int _percent;
        private readonly Random _d100;

        public PercentagePassChecker(int percent):this(percent, new Random()){}

        public PercentagePassChecker(int percent, Random d100)
        {
            _percent = percent;
            _d100 = d100;
        }

        public bool Check(Feature feature, IFeatureUser user)
        {
            return _d100.Next(0, 99) < _percent;
        }
    }
}
