namespace Features.Test
{
    public class MockChecker : FeatureChecker
    {
        private readonly bool _passed;

        public MockChecker(bool passed)
        {
            _passed = passed;
        }

        public MockChecker():this(true){}

        public bool Check(Feature feature)
        {
            this.CheckCount++;
            this.Checked = feature;
            return _passed;
        }

        public int CheckCount { get; set; }
        public Feature Checked { get; private set; }
    }
}