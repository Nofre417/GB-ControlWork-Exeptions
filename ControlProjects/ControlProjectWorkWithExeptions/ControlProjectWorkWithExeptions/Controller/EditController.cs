using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ControlProjectWorkWithExeptions
{
    public class EditController
    {
        Model model;
        Repository repository = new();
        ConsoleManager consoleManager = new();

        public EditController(Model model)
        {
            this.model = model;
        }

        public string userInput {  get; set; }

        public bool AskToAction()
        {
            consoleManager.ColorfulOutput("Do your want to save or edit (s/e)? ", "DarkYellow", space: false);
            userInput = consoleManager.Input();
            if (userInput == "e")
            {
                return true; 
            } 
            else if (userInput == "s") { }
            {
                if (repository.save(model.GetDataPerson()))
                {
                    consoleManager.ColorfulOutput("Data person successfully saved", "DarkGreen");
                }
                else
                {
                    consoleManager.ColorfulOutput("Error during saving", "DarkRed");
                }
                return false;
            }
        }


        public void Edit()
        {
            consoleManager.DisplayConsoleSpliter();
            consoleManager.PrintCommandsToEdit();
            consoleManager.PrintFullData(model.GetDataPerson());
            userInput = consoleManager.Input("Enter code");
            consoleManager.DisplayConsoleSpliter();

            if (userInput == "1")
            {
                userInput = consoleManager.Input("Enter new full name");
                if (!model.EditFullName(userInput))
                {
                    consoleManager.ColorfulOutput("Entered incorrect data, please repeat again", "DarkRed");
                    Edit();
                }


                if (AskToAction())
                {
                    Edit();
                }
                else
                {
                    return;
                }


            }
            if (userInput == "2")
            {
                userInput = consoleManager.Input("Enter new date of birth");
                if (!model.EditDateOfBirth(userInput))
                {
                    consoleManager.ColorfulOutput("Entered incorrect data, please repeat again", "DarkRed");
                    Edit();
                }
                if (AskToAction())
                {
                    Edit();
                }
                else
                {
                    return;
                }
            }
            if (userInput == "3")
            {
                userInput = consoleManager.Input("Enter new phone number");

                if (!model.EditPhoneNumber(userInput))
                {
                    consoleManager.ColorfulOutput("Entered incorrect data, please repeat again", "DarkRed");
                    Edit();
                }

                if (AskToAction())
                {
                    Edit();
                }
                else
                {
                    return;
                }
            }
            if (userInput == "4")
            {
                userInput = consoleManager.Input("Enter new gender");

                if (!model.EditGender(userInput))
                {
                    consoleManager.ColorfulOutput("Entered incorrect data, please repeat again", "DarkRed");
                    Edit();
                }

                if (AskToAction())
                {
                    Edit();
                }
                else
                {
                    return;
                }
            }
            if(userInput == "0")
            {
                return;
            }
            else
            {
                return;
            }
        }
    }
}
