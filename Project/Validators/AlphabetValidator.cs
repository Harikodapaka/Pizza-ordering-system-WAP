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
    class AlphabetValidator: ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string input = value.ToString().Trim();
            if (!Regex.IsMatch(input, (@"^[a-zA-Z ]+$")))
            {
                return new ValidationResult(false, "Only Alphabets allowed!!");
            }

            return ValidationResult.ValidResult;
        }
    }
}
