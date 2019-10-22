using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using PatientApp.Controllers;


namespace PatientApp.Models
{
    [MetadataType(typeof(PatientMetadata))]
    public partial class Patient
    {
        public string ConfirmPassword { get; set; }
    }
    public class PatientMetadata
    {
        [Display(Name ="First Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage ="First name required")]
        public string FirstName { get; set; }
 
        [Display(Name = "Last Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Last name required")]
        public string LastName { get; set; }
 
        [Display(Name ="Email ID")]
        [Required(AllowEmptyStrings =false, ErrorMessage ="Email ID required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        

         [Display(Name = "Age")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Age required")]
        public int Age { get; set; }

       
        [Display(Name ="Date of birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString ="{0:MM/dd/yyyy}")]
        public DateTime Dob {get;set;}


         [Display(Name = "Gender")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Gender required")]
        public string Gender { get; set; }


         [Display(Name = "Patient Type")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Patient Name required")]
        public string Ptype { get; set; }

 
        [Required(AllowEmptyStrings =false, ErrorMessage ="Password is required")]
        [DataType(DataType.Password)]
        [MinLength(6,ErrorMessage ="Minimum 6 characters required")]
        public string Password { get; set; }
 
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Confirm password and password do not match")]
        public string ConfirmPassword { get; set; }
 
    }
}
