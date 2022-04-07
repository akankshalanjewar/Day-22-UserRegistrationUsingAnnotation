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
            Console.WriteLine("user Registration Validation");
            Console.WriteLine("************************************");

            UserRegistration userRegistration = new UserRegistration();
            userRegistration.FirstName1 = FirstName;

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
            }

            Console.ReadKey();
        }
    }

}
    

