using System;
using System.Collections.Generic;

namespace Indexers
{
    public class HttpCookie
    {
        // Dictionary to store value - key is strig, value is string
        // mark readonly so it cant be re-initiatized later
        private readonly Dictionary<string, string> _dictionary;
        public DateTime Expiry { get; set;  }

        // Create the Indexor - indexor does not have a name - 
        // Use *this* instead var name to create indexor for class
        public string this[string key]
        {
            // just use dictionary to get the value and return it
            // so user see's name[key] vs name.getItem, name..setItem etc.
            get { return _dictionary[key]; }

            // "value" is keyword use to get the right side of '=' sign
            set { _dictionary[key] = value; }
        }

        // ctor
        public HttpCookie()
        {
            // init the dictionary
            _dictionary = new Dictionary<string, string>();
        }
    }
}
