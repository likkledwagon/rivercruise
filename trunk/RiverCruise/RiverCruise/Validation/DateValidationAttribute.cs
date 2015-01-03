using System;
using System.ComponentModel.DataAnnotations;

namespace RiverCruise.Validation
{
    public class DateValidationAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            try
            {
                return (((DateTime)value) >= new DateTime(1900, 01, 01) &&
                        ((DateTime)value) <= DateTime.Now);
            }
            catch
            {
                return false;
            }
        } 
    }
}