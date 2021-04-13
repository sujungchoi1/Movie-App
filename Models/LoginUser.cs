using System;
using System.ComponentModel.DataAnnotations;

namespace MovieApp.Models
{
    public class LoginUser
    {
        [Required(ErrorMessage="Please provide your email")]
        [EmailAddress(ErrorMessage="Please provide a valid email")]
        [Display(Name="Email")]
        public string LoginEmail {get;set;}

        [Required(ErrorMessage="Please provide your password")]
        [DataType(DataType.Password)]
        [Display(Name="Password")]
        public string LoginPassword {get;set;}

    }
}