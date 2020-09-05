using System;
using System.Collections.Generic;

namespace BilgeAdam.Common
{
    public class CustomSortedList
    {
        SortedList<string, string> list = new SortedList<string, string>();

        public int GetItemCount()
        {
            return list.Count;
        }

        public void Add(string key, string value)
        {
            list.Add(key, value);
        }

        public string GetItemAt(int index)
        {
            return list[list.Keys[0]];
        }
    }
}
