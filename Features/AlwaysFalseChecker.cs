namespace Features
{
    public class AlwaysFalseChecker : FeatureChecker
    {
        public bool Check(Feature feature)
        {
            return false;
        }
    }
}