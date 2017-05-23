using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Omack.Data.CustomValidations
{
    public class IsBelowCurrentDate: ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var dateTime = Convert.ToDateTime(value);
            //return true if input date is below or equal to current time. Otherwise return false.
            return (dateTime <= DateTime.UtcNow);  
        }
    }
}
