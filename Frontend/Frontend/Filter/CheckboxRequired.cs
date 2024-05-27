﻿using System.ComponentModel.DataAnnotations;

namespace Frontend.Filter
{
    public class CheckboxRequired: ValidationAttribute
    {
        public override bool IsValid(object? value) => value is bool b && b;
    
    }
}
