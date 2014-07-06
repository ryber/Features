using System.Collections.Generic;
using System.Globalization;

namespace Features
{
    public interface IFeatureUser
    {
        CultureInfo Culture { get; }
        IEnumerable<string> Groups { get; }
    }
}