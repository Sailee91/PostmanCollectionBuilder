using System.Collections.Generic;

namespace PostmanCollectionBuilder
{
    public class PostmanCollectionRootObject
    {
        public Info Info { get; set; }
        public IEnumerable<Item> Item { get; set; }
    }
}