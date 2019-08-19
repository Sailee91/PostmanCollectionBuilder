using System.Collections.Generic;

namespace PostmanCollectionBuilder
{
    public class PostmanCollectionProperties
    {
        public string CollectionName { get; set; }
        public IEnumerable<Item> Items { get; set; }
    }
}