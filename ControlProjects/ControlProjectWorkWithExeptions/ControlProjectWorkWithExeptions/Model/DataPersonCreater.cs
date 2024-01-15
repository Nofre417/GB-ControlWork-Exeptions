

namespace ControlProjectWorkWithExeptions
{
    public class DataPersonCreater
    {
        InputValidation validation = new();
        UserInputFormatter inputFormatter = new();
        public DataPersonCreater() 
        {

        }

        public DataPerson Create(string[] values, DataPerson person)
        {
            foreach(string item in values)
            {
                if (validation.nameValidation(item))
                {
                    string FullName = inputFormatter.ToFormatName(item);
                    
                    if (person.FullName == null)
                    {
                        person.FullName = FullName;
                    }
                    else
                    {
                        person.FullName += " " + FullName;
                    }                 
                }
                if (validation.yearValidation(item))
                {
                    person.DateOfBirth += inputFormatter.ToFormatDate(item);
                }
                if (validation.numberValidation(item))
                {
                    person.PhoneNumber += item;
                }
                if (validation.genderValidation(item))
                {
                    person.Gender += inputFormatter.ToFormatGender(item);
                }
            }
            return person;
        }
    }
}
