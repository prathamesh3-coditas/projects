using System;
using System.Collections.Generic;

namespace Scaffolding.Models
{
    public partial class SubCatagory
    {
        public SubCatagory()
        {
            Products = new HashSet<Product>();
        }

        public int SubCatagoryId { get; set; }
        public string SubCatagoryName { get; set; } = null!;
        public int? CatagoryId { get; set; }

        public virtual Catagory? Catagory { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
