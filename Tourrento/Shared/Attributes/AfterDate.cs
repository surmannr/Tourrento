using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tourrento.Shared.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class AfterDate : ValidationAttribute
    {
        public string DateName { get; set; }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTimeOffset date = (DateTimeOffset)value;

            // Reflection
            var dateProperty = validationContext.ObjectType.GetProperty(DateName);
            var datePropertyValue = (DateTimeOffset)dateProperty.GetValue(validationContext.ObjectInstance, null);

            if (date >= datePropertyValue)
            {
                return ValidationResult.Success;
            }

            return new ValidationResult($"A dátum nem lehet korábban a {datePropertyValue} dátumnál.");
        }
    }
}
