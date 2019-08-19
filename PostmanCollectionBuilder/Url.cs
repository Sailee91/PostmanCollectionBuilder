using System.Collections.Generic;

namespace PostmanCollectionBuilder
{
    public class Url
    {
        public string Raw { get; set; }
        public string Protocol { get; set; }
        public IEnumerable<string> host { get; set; }
        public string port { get; set; }
        public IEnumerable<string> path { get; set; }
    }
}