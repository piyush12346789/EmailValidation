using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace EmailValidation
{
    class Class1
    {
        string result = "^[0-9a-zA-Z]{1,}([._+-][0-9a-zA-Z]+)*[@][0-9a-zA-Z]{1,}.[a-zA-Z]{2,3}(.[a-zA-Z]{2,3})?$";
        public bool ValidateEmail(string Email)
        {
            return Regex.IsMatch(Email, result);
        }
    }
}
