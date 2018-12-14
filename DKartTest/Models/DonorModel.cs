using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DKartTest.Models
{
    public class DonorModel
    {
        [Required]
        public string Name { get; set; }
        
        [Required][EmailAddress][Display(Name="Email ID")]
        public string EmailId { get; set; }

        [Required][Phone]
        public string Phone { get; set; }
    }
}