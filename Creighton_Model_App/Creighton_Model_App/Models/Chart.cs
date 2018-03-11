using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Creighton_Model_App.Models
{
    public class Chart
    {
        [Key]
        public int ChartId { get; set; }

        [Required]
        DateTime DateTimeCreated { get; set; }

        [Required]
        DateTime CurrentDate { get; set; }

        public virtual ICollection<ApplicationUser> ApplicationUser { get; set; }

    }
}