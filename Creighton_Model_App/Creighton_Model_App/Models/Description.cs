using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Creighton_Model_App.Models
{
    public class Description
    {
        [Key]
        public int DescriptionId { get; set; }

        [Required]
        public string Description { get; set; }

        public virtual ICollection<Chart> Charts { get; set; }

        public virtual ICollection<ApplicationUser> ApplicationUser { get; set; }


    }
}
