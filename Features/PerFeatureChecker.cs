using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features
{
    public class PerFeatureChecker : IFeatureChecker
    {
        private readonly Multimap<Feature, IFeatureChecker> _checkers = new Multimap<Feature, IFeatureChecker>();

        public void Add(Feature feature, IFeatureChecker featureChecker)
        {
            _checkers.Add(feature, featureChecker);
        }

        public bool Check(Feature feature, IFeatureUser user)
        {
            if (_checkers.ContainsKey(feature))
            {
                return _checkers[feature].Any(c => c.Check(feature, user));
            }
            return false;
        }
    }
}
