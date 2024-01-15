using System.Text.RegularExpressions;

namespace ControlProjectWorkWithExeptions
{
    public class InputValidation
    {
        Regex regex;

        public InputValidation() 
        {

        }

        public bool inputValidation(string input)
        {
            string pattern = @"(?=.*\b\w{2,}\b)(?=.*\d)(?=.*[./])(?=.*[fFmM])";
            regex = new Regex(pattern);
            return regex.IsMatch(input);
        }

        public bool nameValidation(string input)
        {
            string pattern = @"^[а-яА-Яa-zA-Z]{2,}$";
            regex = new Regex(pattern);
            return regex.IsMatch(input);
        }

        public bool fullnameValidation(string input)
        {
            string pattern = @"^[\p{L}\s]+$";
            regex = new Regex(pattern);
            return regex.IsMatch(input);
        }

        public bool numberValidation(string input)
        {
            string pattern = @"^\d{11}$";
            regex = new Regex(pattern);
            return regex.IsMatch(input);
        }
        public bool yearValidation(string input)
        {
            string pattern = @"^(0[1-9]|[12][0-9]|3[01]).(0[1-9]|1[0-2]).\d{4}$";
            regex = new Regex(pattern);
            return regex.IsMatch(input);
        }
        public bool genderValidation(string input)
        {
            string pattern = @"^[fFmMмМжЖ]+$";
            regex = new Regex(pattern);
            return regex.IsMatch(input);
        }
    }
}
