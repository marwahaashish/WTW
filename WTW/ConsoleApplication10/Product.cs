using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WTW
{
    public class ProductJson
    {
        [JsonProperty("Product")]
        public Product Product { get; set; }
    }

    public class Product
    {
        public string Name { get; set; }
        public decimal? Variety1 { get; set; }
        public decimal? Variety2 { get; set; }
        public decimal? Variety3 { get; set; }
        public decimal? Variety4 { get; set; }
    }
}
