using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Common
{
    public class CustomHashSet
    {
        private HashSet<string> values = new HashSet<string>();

        public int GetItemCount()
        {
            return values.Count;
        }

        public void Add(string value)
        {
            values.Add(value);
        }

        public void Add(params string[] values)
        {
            foreach (var value in values)
            {
                this.values.Add(value);
            }
        }

        public void Remove(string value)
        {
            values.Remove(value);
        }

        public bool Has(string value)
        {
            return values.Contains(value);
        }
    }
}
