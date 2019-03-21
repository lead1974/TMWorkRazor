using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TMWork.GoogleReCaptcha.Web.Validation;

namespace TMWork.ViewModels
{
    public class ContactVM //: GoogleReCaptchaModelBase
    {

        [Display(Name = "Name")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Display(Name = "Phone")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Message")]
        [DataType(DataType.Text)]
        public string Message { get; set; }

        [Display(Name = "Agree Terms")]
        public bool AgreeTerms { get; set; }

        public string Status { get; set; }

    }
}
