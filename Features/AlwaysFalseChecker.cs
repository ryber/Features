namespace Features
{
    public class AlwaysFalseChecker : FeatureChecker
    {
        public bool check(Feature feature)
        {
            return false;
        }
    }
}