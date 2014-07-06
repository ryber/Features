namespace Features
{
    public interface IFeatureChecker
    {
        bool Check(Feature feature, IFeatureUser user);
    }
}