using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace UserRegistrationUsingAnnotation
{
    public class Annotation
    {
        public static void Dispaly()
        {
            Console.WriteLine("Enter First Name");
            string FirstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name");
            string LastName = Console.ReadLine();

            Console.WriteLine("Enter Email Id");
            string EmailId= Console.ReadLine();

            Console.WriteLine("Enter phone number");
            string PhoneNumber= Console.ReadLine();

            Console.WriteLine("Enter passward ");
            string passward = Console.ReadLine();

            Console.WriteLine("user Registration Validation");
            Console.WriteLine("************************************");

            UserRegistration userRegistration = new UserRegistration();
            userRegistration.FirstName1 = FirstName;
            userRegistration.LastName1 = LastName;
            userRegistration.EmailId1 = EmailId;
            userRegistration.PhoneNumber1 = PhoneNumber;
            userRegistration.Password1 = passward;

            ValidationContext context = new System.ComponentModel.DataAnnotations.ValidationContext(userRegistration, null, null);
            List<ValidationResult> results = new List<ValidationResult>();

            bool valid = Validator.TryValidateObject(userRegistration, context, results, true);
            if (!valid)
            {
                foreach (ValidationResult TotalResult in results)
                {
                    Console.WriteLine("Item : {0}", TotalResult.MemberNames.First(), Environment.NewLine);
                    Console.WriteLine("Error Msg : {0}", TotalResult.ErrorMessage, Environment.NewLine);
                }
            }
            else
            {
                Console.WriteLine("FirstName: " + userRegistration.FirstName1);
                Console.WriteLine("LastName:"  + userRegistration.LastName1);
                Console.WriteLine("EmailId:" + userRegistration.EmailId1);
                Console.WriteLine("PhoneNumber:"+userRegistration.PhoneNumber1);
                Console.WriteLine("passward:" +userRegistration.Password1);
            }

            
        }
    }

}
    

