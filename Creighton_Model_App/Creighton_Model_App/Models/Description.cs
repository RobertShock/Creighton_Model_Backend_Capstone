﻿using System;
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
        public string Observation { get; set; }

        public virtual List<ChartEntry> ChartEntries { get; set; }
    }
}
