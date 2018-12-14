using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DKartTest.Models
{
    public class MailDetailsModel
    {
        [Display(Name="To")][EmailAddress][Required]
        public string ToMailId { get; set; }

        [Display(Name = "From")][EmailAddress][Required]
        public string FromMailId { get; set; }

        [Required]
        public string Subject { get; set; }

        public string Body { get; set; }
    }
}