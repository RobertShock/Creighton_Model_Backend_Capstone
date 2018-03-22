using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Creighton_Model_App.Models
{
    public class ChartEntry
    {
        [Key]
        public int ChartEntryId { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }

        [Required]
        public virtual ApplicationUser User { get; set; }

        public int StickerId { get; set; }

        public int DescriptionId { get; set; }

        public Sticker sticker { get; set; }

        public Description description { get; set; }
    }
}