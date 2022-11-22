using System;
using System.Collections.Generic;
using API_Apps.CustomValidator;

namespace API_Apps.models
{
    public partial class Product
    {
        public int ProductId { get; set; }

        //[ProductValidator(ErrorMessage = "Invalid name")]
        public string ProductName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int Price { get; set; }
        public int CatagoryId { get; set; }
        public int ManufacturerId { get; set; }
        public int? SubCatagoryId { get; set; }

        //public virtual Catagory? Catagory { get; set; } = null!;
    }
}
