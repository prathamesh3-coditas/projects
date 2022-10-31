using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_0710_DB_Connect.Models
{
    public class Catagory
    {
        public int CatagoryId { get; set; }

        public string CatagoryName { get; set; } = string.Empty;

        public int BasePrice { get; set; }
    }


    public class Product
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public int Price { get; set; }

        public int CatagoryId { get; set; }

        public int ManufacturerId { get; set; }

        public int SubCatagoryId { get; set; }

    }

}
