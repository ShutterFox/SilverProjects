using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SilverProjects.Models
{
    using System.ComponentModel;

    public class MPGIndexViewModel
    {
        [DisplayName("Cost per Litre")]
        public decimal CostPerL { get; set; }

        [DisplayName("Amount Pumped")]
        public decimal CostPumped { get; set; }

    [DisplayName("Miles Travelled")]
        public decimal Miles { get; set; }

        [DisplayName("Result")]
        public decimal Result { get; set; }
    }
}