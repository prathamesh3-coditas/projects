using System;
using System.Collections.Generic;

namespace Scaffolding.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int Price { get; set; }
        public int CatagoryId { get; set; }
        public int ManufacturerId { get; set; }
        public int? SubCatagoryId { get; set; }

        public virtual Catagory Catagory { get; set; } = null!;
        public virtual Manufacturer Manufacturer { get; set; } = null!;
        public virtual SubCatagory? SubCatagory { get; set; }
    }
}
