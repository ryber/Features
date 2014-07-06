namespace Features
{
    public static class FeatureCheckFactory
    {
        public static IFeatureChecker Checker { get; set; }
        public static IAppContext Context { get; set; } 

        static FeatureCheckFactory()
        {
            Reset();
        }

        public static bool IsEnabled(this Feature feature)
        {
            return IsEnabled(feature, Context.CurrentUser);
        }

        public static bool IsEnabled(this Feature feature, IFeatureUser user)
        {
            return Checker.Check(feature, user);
        }

        public static void Reset()
        {
            Checker = new AlwaysFalseChecker();
            Context = new DefaultContext();
        }
    }

    public class DefaultContext : IAppContext
    {
        public IFeatureUser CurrentUser { get {return new UnknownUser();} }
    }
}