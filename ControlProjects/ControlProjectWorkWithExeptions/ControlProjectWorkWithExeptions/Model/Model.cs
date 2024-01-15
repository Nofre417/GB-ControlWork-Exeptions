
namespace ControlProjectWorkWithExeptions
{
    public class Model 
    {
        DataPerson dataPerson;
        InputValidation validation = new();
        EditDataPerson editDataPerson = new();
        DataPersonCreater personCreater = new();
        Repository repository = new();

        public string userInput {  get; set; }

        public Model() { }

        private string[] UserInputSplitter()
        {
            string[] splitedUserInput = userInput.Split(' ');
            return splitedUserInput;
        }

        public bool ValidateInput()
        {
            return validation.inputValidation(userInput);
        }

        #region GET_DATA_REROSON
        public DataPerson GetDataPerson()
        {
            return dataPerson;
        }
        #endregion

        #region CREATE_DATA_PERSON
        public bool CreateDataPerson()
        {
            if (!ValidateInput())
            {
                return false;
            }
            dataPerson = new();
            dataPerson = personCreater.Create(UserInputSplitter(), dataPerson);
            return true;
        }
        #endregion

        #region EDITING_DATA_PERSON
        public bool EditFullName(string fullName)
        {
            if (!validation.fullnameValidation(fullName))
            {
                return false;
            }
            dataPerson = editDataPerson.EditFullName(fullName, dataPerson);
            return true;
        }
        public bool EditPhoneNumber(string phoneNumber)
        {
            if (!validation.numberValidation(phoneNumber))
            {
                return false;
            }
            dataPerson = editDataPerson.EditPhoneNumber(phoneNumber, dataPerson);
            return true;
        }
        public bool EditDateOfBirth(string dateOfBirth)
        {
            if (!validation.yearValidation(dateOfBirth))
            {
                return false;
            }
            dataPerson = editDataPerson.EditDateOfBirth(dateOfBirth, dataPerson);
            return true;
        }
        public bool EditGender(string gender)
        {
            if (!validation.genderValidation(gender))
            {
                return false;
            }
            dataPerson = editDataPerson.EditGender(gender, dataPerson);
            return true;
        }
        #endregion


    }
}
