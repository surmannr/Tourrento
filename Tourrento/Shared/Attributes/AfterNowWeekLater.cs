﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tourrento.Shared.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class AfterNowWeekLater : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTimeOffset date = (DateTimeOffset)value;

            if (date >= DateTimeOffset.Now.AddDays(7))
            {
                return ValidationResult.Success;
            }

            return new ValidationResult("A dátumnak a mai dátumhoz képest minimum egy héttel későbbnek kell lennie.");
        }
    }
}
