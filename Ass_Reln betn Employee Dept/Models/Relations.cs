using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass_Reln_betn_Employee_Dept.Models
{

    public class Department
    {
        //[Key]
        public int DeptNo { get; set; }

        //[Required]
        //[StringLength(50)]
        public string? DeptName { get; set; }

        //[Required]
        public int BasePrice { get; set; }

        public ICollection<Relations>? Employess { get; set; }
    }
    public class Relations
    {
        //[Key]
        public int EmpId { get; set; }


        //[Required]
        //[StringLength(50)]
        public string? EmpName { get; set; }


        //[Required]
        public int Age { get; set; }

        //[Required]
        public int salary { get; set; }

        
        public int DeptNo { get; set; }

        public Department Dept { get; set; }
    }


}
