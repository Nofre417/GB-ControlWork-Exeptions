using static System.Console;

namespace ControlProjectWorkWithExeptions
{
    public class View
    {
        Model model;
        ConsoleManager consoleManager;
        EditController editController;

        private string userInput = String.Empty;

        public View() 
        {
            model = new Model();
            consoleManager = new();
            editController = new(model);
        }

        public void Start()
        {
            consoleManager.ProgramText();
            consoleManager.PrintCommands();
            userInput = AskUserInput("Enter code of actions");
            if(userInput == "0")
            {
                Stop();
            }
            if(userInput == "1")
            {
                consoleManager.ConsoleClear();
                consoleManager.ProgramText();
                Start();
            }
            if(userInput == "2")
            {
                consoleManager.DisplayConsoleSpliter();
                consoleManager.ColorfulOutput("Please enter your data (Full name/date of birth/phone number/gender(f/m))", "DarkYellow");
                consoleManager.ColorfulOutput("Example: Ivanov Ivan Ivanovich 01.01.2001 12345678910 M", "DarkGray");
                userInput = AskUserInput("Your data");
                model.userInput = userInput;

                //Creating personData
                if (!model.CreateDataPerson())
                {
                    consoleManager.DisplayConsoleSpliter();
                    consoleManager.ColorfulOutput("Entered incorrect data", "DarkRed");
                    Repeat();
                }

                consoleManager.PrintFullData(model.GetDataPerson());


                if (editController.AskToAction())
                {
                    editController.Edit();     
                }

                consoleManager.PrintFullData(model.GetDataPerson());
                consoleManager.DisplayConsoleSpliter();

                Repeat();
            }
            else
            {
                consoleManager.ColorfulOutput("Entered incorrect code", "DarkRed");
                Repeat();
            }
        }


        #region VIEW_SERVICES
        public string AskUserInput(string text)
        {
            return consoleManager.Input(text);
        }

        public void Stop()
        {
            Environment.Exit(0);
        }

        public void Repeat()
        {
            userInput =AskUserInput("Do you wants to restart (y/n)?");
            if (userInput == "y")
            {
                consoleManager.ProgramText();
                Start();
            }
            else
            {
                Stop();
            }
        }
        #endregion
    }
}
