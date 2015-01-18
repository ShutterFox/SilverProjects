using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SilverProjects.Models
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public class MPGIndexViewModel
    {
        [Required]
        [Range(0.01, 50)]
        [DisplayName("Cost per Litre (£)")]
        public decimal CostPerL { get; set; }

        [Required]
        [Range(1, 100)]
        [DisplayName("Amount Pumped (£)")]
        public decimal CostPumped { get; set; }

        [Required]
        [Range(1, 1000)]
        [DisplayName("Miles Travelled")]
        public decimal Miles { get; set; }

        public bool CanShowResult { get; set; }

        [DisplayName("Result")]
        public decimal Result { get; set; }
    }
}