using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class Patterns
    {
        public static string firstname = "^[A-Z][a-z]{3,}";
        public static string lastname = "^[A-Z][a-z]{3,}";
        public bool Validation(string sample)
        {
            return Regex.IsMatch(sample, firstname);
        }
    }
}
