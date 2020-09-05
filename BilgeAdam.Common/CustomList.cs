using System;
using System.Collections.Generic;
using System.Linq;

namespace BilgeAdam.Common
{
    public class CustomList
    {
        private List<string> values = new List<string>();

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
            this.values.AddRange(values);
        }

        public bool Has(string value)
        {
            return values.Contains(value);
        }

        public IEnumerable<string> FilterByChar(char letter)
        {
            //yield return "Can";
            //yield return "Laden";
            //yield return "Halil";

            //return new List<string> { "Can", "Laden", "Halil" };

            //COOL YÖNTEM
            foreach (var value in values)
            {
                if (value.IndexOf(letter) > -1)
                {
                    yield return value;
                }
            }

            //KISA YÖNTEM
            //return values.Where(v => v.IndexOf(letter) > -1);

            //KEKO YÖNTEM
            //var filter = new List<string>();
            //foreach (var value in values)
            //{
            //    if(value.IndexOf(letter) > -1)
            //    {
            //        filter.Add(value);
            //    }
            //}

            //return filter;
        }

        public void Remove(string value)
        {
            values.Remove(value);
        }
    }
}
