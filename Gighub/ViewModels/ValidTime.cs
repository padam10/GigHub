﻿namespace Gighub.ViewModels
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Diagnostics;
    using System.Globalization;

    public class ValidTime : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime dateTime;

            var isValid = DateTime.TryParseExact(
                Convert.ToString(value),
                "HH:mm",
                CultureInfo.CurrentCulture,
                DateTimeStyles.None,
                out dateTime);
            Debug.WriteLine(isValid);
            return (isValid);
        }
    }
}