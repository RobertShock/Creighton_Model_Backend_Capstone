﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Creighton_Model_App.Models
{
    public class Sticker
    {
        [Key]
        public int StickerId { get; set; }

        [Required]
        public string StickerColor { get; set; }     
        
        public virtual List<ChartEntry> ChartEntries { get; set; }
    }
}


