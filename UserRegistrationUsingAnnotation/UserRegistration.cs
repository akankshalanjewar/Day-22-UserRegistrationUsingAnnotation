using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace UserRegistrationUsingAnnotation
{
    public class UserRegistration
    {
        

            [Required(ErrorMessage = "Users {0} is required.")]
            [StringLength(100, MinimumLength = 2, ErrorMessage = "Name should have minimum of 3 charcaters and maximum 100 characters")]
            [DataType(DataType.Text)]
            public string FirstName1 { get; set; }
                                                                                                                
            [Required(ErrorMessage ="Users {0} is required.")]
            [StringLength(100, MinimumLength = 2, ErrorMessage ="Name should have minimum of 3 characters and maximum 100 charcters")]
             public string LastName1 { get; set; }
        
    }
}