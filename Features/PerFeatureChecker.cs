using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features
{
    public class PerFeatureChecker : FeatureChecker
    {
        private readonly Multimap<Feature, FeatureChecker> _checkers = new Multimap<Feature, FeatureChecker>();

        public void Add(Feature feature, FeatureChecker featureChecker)
        {
            _checkers.Add(feature, featureChecker);
        }

        public bool Check(Feature feature)
        {
            if (_checkers.ContainsKey(feature))
            {
                return _checkers[feature].Any(c => c.Check(feature));
            }
            return false;
        }
    }
}
