using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlProjectWorkWithExeptions
{
    public class UserInputFormatter
    {
        public UserInputFormatter() { }
        public string ToFormatName(string name)
        {
            string firstDigit = name.Substring(0, 1).ToUpper();
            return firstDigit + name.Substring(1).ToLower();

        }
        public string ToFormatFullName(string fullName)
        {
            string[] splittedName = fullName.Split(" ");
            string newName = null;
            string firstDigit;

            foreach (string item in splittedName)
            {
                firstDigit = item.Substring(0, 1).ToUpper();

                if (newName == null)
                {
                    newName = firstDigit + item.Substring(1).ToLower();
                }
                else
                {
                    newName += " " + firstDigit + item.Substring(1).ToLower();
                }
            }
            return newName;
        }

        public string ToFormatGender(string gender)
        {
            return gender.ToUpper().Replace("M", "Male").Replace("F", "Female").Replace("Ж", "Female").Replace("М", "Male");
        }

        public string ToFormatDate(string date)
        {
            return date.Replace("/", ".");
        }

        public string ToFormatNumber(string number)
        {
            return number.Replace(" ", "");
        }

    }
}
