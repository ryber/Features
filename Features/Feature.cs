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
        bool Check(Feature feature);
    }

    public static class FeatureCheckFactory
    {
        public static FeatureChecker Checker { get; set; }

        static FeatureCheckFactory()
        {
            Reset();
        }

        public static bool IsEnabled(this Feature feature)
        {
            return Checker.Check(feature);
        }

        public static void Reset()
        {
            Checker = new AlwaysFalseChecker();
        }
    }
}
