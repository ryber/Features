using System.Collections.Generic;
using System.Globalization;

namespace Features
{
    public class CountryChecker : IFeatureChecker
    {
        private readonly ISet<CultureInfo> _cultures;

        public CountryChecker(params CultureInfo[] cultures)
        {
            _cultures = new HashSet<CultureInfo>(cultures);
        }

        public bool Check(Feature feature, IFeatureUser user)
        {
            return _cultures.Contains(user.Culture);
        }
    }
}