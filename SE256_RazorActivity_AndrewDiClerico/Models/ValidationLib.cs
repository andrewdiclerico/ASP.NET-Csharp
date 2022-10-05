using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; //necessary for ValidationAttribute
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc.ModelBinding.Validation; // Added for validation purposes (IModelValidator)

namespace SE256_RazorActivity_AndrewDiClerico.Models
{
    public class ValidationLib
    {

    }

    public class MyDateAttribute : ValidationAttribute
    {

        //IsValid will be used to check when a date is added to see if the date is from the past/present
        //and not from the future. in this scenario, the dates should not be future dates
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime _dateJoin = Convert.ToDateTime(value); //take an object and convert to date time

            if (_dateJoin <= DateTime.Now)
            {
                return ValidationResult.Success; //if date is past/present, return success result
            }
            else
            {
                return new ValidationResult(ErrorMessage); //error message
            }


        }

    }

    public class StringOptionsValidate : Attribute, IModelValidator
    {
        public string[] Allowed { get; set; } //array of acceptable string

        public string ErrorMessage { get; set; }

        public IEnumerable<ModelValidationResult> Validate(ModelValidationContext context)
        {
            if(Allowed.Contains(context.Model as string))
            {
                return Enumerable.Empty<ModelValidationResult>();
            }
            else
            {
                return new List<ModelValidationResult> { new ModelValidationResult("", ErrorMessage) };
            }
        }
    }



}
