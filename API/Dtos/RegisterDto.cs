using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class RegisterDto
    {
        [Required]
        public string DisplayName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [RegularExpression("^(?=[^\\d_].*?\\d)\\w(\\w|[!@#$%]){7,20}", ErrorMessage = "Passwords must have 1 uppercase, the length of 8 to 20 aplhanumeric characters and select special characters!")]
        //This regex can be used to restrict passwords to a length of 8 to 20 aplhanumeric characters and select special characters. 
        //The password also can not start with a digit, underscore or special character and must contain at least one digit.
        //Matches:	password1 | pa$$word2 | pa!@#$%3
        //Non-Matches:	password | 1stpassword | $password#
        public string Password { get; set; }

        
    }
}