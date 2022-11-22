using System;
using System.Collections.Generic;

namespace Quiz_App.Models
{
    public partial class SearchTable
    {
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public string? ManufacturerName { get; set; }
        public int? Price { get; set; }
        public string? Seller { get; set; }
        public string? Description { get; set; }
    }
}
