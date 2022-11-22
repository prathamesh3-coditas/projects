using Coditas_MVCApps1_DataAccess.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coditas_MVCApps1_Entities
{
    public class CatagoryProducts
    {
        //public IEnumerable<Catagory> catagories { get; set; }

        public Catagory catInfo;

        public IEnumerable<Product> Products { get; set; }
    }
}
