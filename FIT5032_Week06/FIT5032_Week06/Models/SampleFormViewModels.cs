using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FIT5032_Week06.Models
{
    public class SampleFormViewModels
    {
    }

    public class FormOneViewModel
    {
        [Required]
        [Display(Name = "Week06 First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your lastname!")]
        [StringLength(20,MinimumLength=1,ErrorMessage = "Please enter your lastname between 1 to 20 in length!")]
        [Display(Name = "Week06 Last Name")]
        public string LastName { get; set; }
    }
}