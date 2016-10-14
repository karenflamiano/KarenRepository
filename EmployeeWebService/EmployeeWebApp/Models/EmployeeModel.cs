using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeWebApp.Models
{
    public class EmployeeModel
    {
        public int EmployeeID { get; set; }


        [Required(ErrorMessage = "{0} field is required.")]
        [RegularExpression("([ a-zA-Z-'])+", ErrorMessage = "{0} must not contain any numbers or any special characters.")]
        [Display(Name = "First Name*")]
        [StringLength(35, ErrorMessage = "Maximum length for {0} is 35 characters only.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "{0} field is required.")]
        [RegularExpression("([ a-zA-Z-'])+", ErrorMessage = "{0} must not contain any numbers or any special characters.")]
        [Display(Name = "Middle Name")]
        [StringLength(35, ErrorMessage = "Maximum length for {0} is 35 characters only.")]
        public string MiddleName { get; set; }


        [Required(ErrorMessage = "{0} field is required.")]
        [RegularExpression("([ a-zA-Z-'])+", ErrorMessage = "{0} must not contain any numbers or any special characters.")]
        [Display(Name = "Last Name*")]
        [StringLength(35, ErrorMessage = "Maximum length for {0} is 35 characters only.")]
        public string LastName { get; set; }


        [Required(ErrorMessage = "{0} field is required.")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Birth Date*")]
        public DateTime BirthDate { get; set; }


        [Required(ErrorMessage = "{0} field is required.")]
        [EmailAddress(ErrorMessage = "Please type a proper {0}. (e.g. 'email@gmail.com')")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Please enter a valid e-mail adress")]
        [StringLength(155, ErrorMessage = "Email Address is too long.")]
        [Display(Name = "Email Address*")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

    }
}