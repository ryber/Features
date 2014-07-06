namespace Features.Test
{
    public class MockChecker : IFeatureChecker
    {
        private readonly bool _passed;

        public MockChecker(bool passed)
        {
            _passed = passed;
        }

        public MockChecker():this(true){}

        public bool Check(Feature feature, IFeatureUser user)
        {
            this.CheckCount++;
            this.Checked = feature;
            return _passed;
        }

        public int CheckCount { get; set; }
        public Feature Checked { get; private set; }
    }
}