using System;
using System.Collections.Generic;
using API_Apps.CustomValidator;

namespace API_Apps.models
{
    public partial class Catagory
    {
        //public Catagory()
        //{
        //    Products = new HashSet<Product>();
        //}

        [CatagoryValidator]

        public int CatagoryId { get; set; }

        public string CatagoryName { get; set; } = null!;
        public int BasePrice { get; set; }

        //public virtual ICollection<Product>? Products { get; set; } = null!;
    }
}
