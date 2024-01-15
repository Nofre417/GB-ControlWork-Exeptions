using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlProjectWorkWithExeptions
{
    public class EditDataPerson
    {
        UserInputFormatter inputFormatter = new();
        public EditDataPerson() { }

        public DataPerson EditFullName(string NewFullName, DataPerson person)
        {
            NewFullName = inputFormatter.ToFormatFullName(NewFullName);
            person.FullName = NewFullName;
            return person;
        }
        public DataPerson EditPhoneNumber(string NewPhoneNumber, DataPerson person)
        {
            person.PhoneNumber = inputFormatter.ToFormatNumber(NewPhoneNumber);
            return person;
        }
        public DataPerson EditDateOfBirth(string NewDateOfBirth, DataPerson person)
        {
            person.DateOfBirth = inputFormatter.ToFormatDate(NewDateOfBirth);
            return person;
        }
        public DataPerson EditGender(string NewGender, DataPerson person)
        {
            person.Gender = inputFormatter.ToFormatGender(NewGender);
            return person;
        }

    }
}
