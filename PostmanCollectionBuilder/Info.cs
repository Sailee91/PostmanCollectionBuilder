using System;

namespace PostmanCollectionBuilder
{
    public class Info
    {
        public string _Postman_Id => Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string Schema => "https://schema.getpostman.com/json/collection/v2.1.0/collection.json";
    }
}