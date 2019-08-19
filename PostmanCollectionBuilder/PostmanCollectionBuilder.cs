using System;

namespace PostmanCollectionBuilder
{
    public static class PostmanCollectionBuilder
    {
        public static PostmanCollectionRootObject BuildPostmanCollection(PostmanCollectionProperties postmanCollectionProperties)
        {
            if(postmanCollectionProperties == null)
            {
                throw new ArgumentNullException(nameof(postmanCollectionProperties), "PostmanCollectionProperties cannot be null");
            }

            return new PostmanCollectionRootObject
            {
                Info = new Info
                {
                    Name = postmanCollectionProperties.CollectionName,
                },
                Item = postmanCollectionProperties.Items
            };
        }
    }
}
