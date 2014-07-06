using System.Collections.Generic;
using System.Globalization;

namespace Features
{
    internal class UnknownUser : IFeatureUser
    {
        public CultureInfo Culture { get { return CultureInfo.CurrentCulture; } }
        public IEnumerable<string> Groups { get { return new List<string>(); } }
    }
}