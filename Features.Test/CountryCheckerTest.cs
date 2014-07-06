using System.Collections.Generic;
using System.Globalization;
using NUnit.Framework;

namespace Features.Test
{
    [TestFixture]
    public class CountryCheckerTest
    {
         [Test]
         public void ByDefaultNoCountriesPass()
         {
             var checker = new CountryChecker();
             Assert.False(checker.Check(Feature.Doughnuts, new TestUser()));
         }

        [Test]
        public void WillPassWhenUserHasMatchingCulture()
        {
            var checker = new CountryChecker(CultureInfo.GetCultureInfo("fr-CA"));
            var user = new TestUser { Culture = CultureInfo.GetCultureInfo("fr-CA") };

            Assert.True(checker.Check(Feature.Doughnuts, user));
        }

        [Test]
        public void WillNotPassWithMismatchedCultures()
        {
            var checker = new CountryChecker(CultureInfo.GetCultureInfo("fr-CA"));
            var user = new TestUser { Culture = CultureInfo.GetCultureInfo("fr-FR") };

            Assert.False(checker.Check(Feature.Doughnuts, user));
        }
    }

    public class TestUser : IFeatureUser
    {
        public CultureInfo Culture { get; set; }
        public IEnumerable<string> Groups { get; set; }
    }
}