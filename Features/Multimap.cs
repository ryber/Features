using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features
{
    public class Multimap<TKey,TValue> : Dictionary<TKey, IList<TValue>>
    {
        public void Add(TKey key, TValue value)
        {
            IList<TValue> values;
            if (!this.TryGetValue(key, out values))
            {
                values = new List<TValue>();
                this.Add(key, values);
            }
            values.Add(value);
        }
    }
}
