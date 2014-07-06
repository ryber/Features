namespace Features
{
    public interface IAppContext
    {
        IFeatureUser CurrentUser { get; }
    }
}