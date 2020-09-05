using System;
using System.Collections.Generic;

namespace BilgeAdam.Common
{
    public class CustomDictionary
    {
        Dictionary<string, string> translator = new Dictionary<string, string>();

        public object GetItemCount()
        {
            return translator.Count;
        }

        public void Add(string key, string value)
        {
            translator.Add(key, value);
        }

        public void Remove(string key)
        {
            translator.Remove(key);
        }

        public bool Has(string key)
        {
            return translator.ContainsKey(key);
        }

        public string TranslateToTurkish(string value)
        {
            return translator[value];
        }

        public string TranslateToEnglish(string value)
        {
            //ULTRA KEKO YÖNTEM
            var has = translator.ContainsValue(value);
            if (has)
            {
                foreach (var item in translator)
                {
                    if (item.Value == value)
                    {
                        return item.Key;
                    }
                }
            }
            return string.Empty;
        }
    }
}
