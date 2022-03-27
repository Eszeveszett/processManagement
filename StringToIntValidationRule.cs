using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Controls;      //  A ValidationRule névtere
using System.Globalization;         //  A CultureInfo névtere

namespace processManagement
{
    internal class StringToIntValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            int i;
            if (int.TryParse(value.ToString(), out i))
            {
                return new ValidationResult(true, null);
            } 

            return new ValidationResult(false, "Csak egész szám lehet");
        }
    }
}
