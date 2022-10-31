using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First.Models
{
    public class Person
    {
        [Key]
        public int PersonUniqueId { get; set; }

        [Required]
        [StringLength(50)]
        public string PersonId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }


        [Required]
        [StringLength(100)]
        public string Address { get; set; }

        [Required]
        public int Age { get; set; }


        [Required]
        [StringLength(100)]
        public string Email { get; set; }
    }
}
