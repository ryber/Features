 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features
{
    public enum Feature
    {
        TimeTravel,
        WarpSpeed,
        Doughnuts
    }

    public interface FeatureChecker
    {
        bool check(Feature feature);
    }

    public static class FeatureCheckFactory
    {
        public static FeatureChecker Checker { get; set; }

        static FeatureCheckFactory()
        {
            Reset();
        }

        public static bool isEnabled(this Feature feature)
        {
            return Checker.check(feature);
        }

        public static void Reset()
        {
            Checker = new AlwaysFalseChecker();
        }
    }
}
