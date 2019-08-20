using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Project.Validators
{
    class NumericValidator : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string input = value.ToString().Trim();
            if (!Regex.IsMatch(input, (@"^[0-9]+$")))
            {
                return new ValidationResult(false, "Only numbers allowed!!");
            }

            return ValidationResult.ValidResult;
        }
    }
}