using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creighton_Model_App.Models
{
    public class LayoutViewModel
    {
        public IConfiguration _Configuration { get; set; }

        public LayoutViewModel(IConfiguration config)
        {
            _Configuration = config;
        }
    }
}
