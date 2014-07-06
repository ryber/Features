using System.Collections.Generic;

namespace Features
{
    public class Multimap<TKey,TValue> : Dictionary<TKey, IList<TValue>>
    {
        public void Add(TKey key, TValue value)
        {
            IList<TValue> values;
            if (!TryGetValue(key, out values))
            {
                values = new List<TValue>();
                Add(key, values);
            }
            values.Add(value);
        }
    }
}
