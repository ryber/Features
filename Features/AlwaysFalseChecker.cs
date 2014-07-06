namespace Features
{
    public class AlwaysFalseChecker : IFeatureChecker
    {
        public bool Check(Feature feature, IFeatureUser user)
        {
            return false;
        }
    }
}