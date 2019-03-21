using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMWork.GoogleReCaptcha.Web.Validation;

namespace TMWork.Data.Core.Domain
{ 
    public class State
    {
        [Key]
        public int StateId { get; set; }

        [Display(Name = "First Name")]
        [Required]
        public string StateName { get; set; }
    }
}
