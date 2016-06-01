using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gighub.ViewModels
{
    using System.ComponentModel.DataAnnotations;
    using System.Diagnostics;

    public class FutureDate:ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime dateTime;
            if (value == null)
            {
                return false; 
            }
            var isValid = DateTime.TryParse(value.ToString(),out dateTime);
            //var isValid = DateTime.TryParseExact(
            //    Convert.ToString(value),
            //    "MM dd yyyy",
            //    CultureInfo.CurrentCulture,
            //    DateTimeStyles.None,
            //    out dateTime);
            Debug.WriteLine(isValid);
            return (isValid && dateTime > DateTime.Now);
        }
    }
}