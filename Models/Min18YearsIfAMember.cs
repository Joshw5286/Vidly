using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Min18YearsIfAMember: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;

            if(customer.MembershipTypeId == MembershipType.Unkown || customer.MembershipTypeId == 1)
            {
                return ValidationResult.Success;
            }

            if(customer.DOB == null)
            {
                return new ValidationResult("A date of birth is required for subscribers.");
            }

            var age = DateTime.Today.Year - customer.DOB.Value.Year;

            return (age >= 18 
                ? ValidationResult.Success 
                : new ValidationResult("Customer should be at least 18 years old to create a membership."));
        }
    }
}