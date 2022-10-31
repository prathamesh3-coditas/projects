using System;
using System.Collections.Generic;

namespace Scaffolding.Models
{
    public partial class Catagory
    {
        public Catagory()
        {
            Products = new HashSet<Product>();
            SubCatagories = new HashSet<SubCatagory>();
        }

        public int CatagoryId { get; set; }
        public string CatagoryName { get; set; } = null!;
        public int BasePrice { get; set; }

        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<SubCatagory> SubCatagories { get; set; }
    }
}
