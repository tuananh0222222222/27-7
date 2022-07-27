using System.Collections.Generic;
using _72core.Models;

namespace _72core.Services
{
    public class ProductListService
    {
        public List<Product> product { get; set; } = new List<Product>()
            {
                new Product(){Name="tuan",Des="anh",Price=1000},
                new Product(){Name="tuan",Des="anh",Price=2000},
                new Product(){Name="tuan",Des="anh",Price=20500},
                new Product(){Name="tuan",Des="anh",Price=206700},
                new Product(){Name="tuan",Des="anh",Price=3000}
            };

    }
}
