using System.Collections.Generic;

namespace PostmanCollectionBuilder
{
    public class Item
    {
        public string name { get; set; }
        public Request request { get; set; }
        public List<object> response { get; set; }
    }
}