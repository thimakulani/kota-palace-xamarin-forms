using Plugin.CloudFirestore.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace kota.Models
{
    public class Customer
    {
        [Id]
        public string Id { get; set; }
        [MapTo("names")]
        public string Name { get; set; }
    }
}
