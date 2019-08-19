using System.Collections.Generic;

namespace PostmanCollectionBuilder
{
    public class Request
    {
        public string Method { get; set; }
        public IEnumerable<Header> Header { get; set; }
        public Body Body { get; set; }
        public Url Url { get; set; }
    }
}