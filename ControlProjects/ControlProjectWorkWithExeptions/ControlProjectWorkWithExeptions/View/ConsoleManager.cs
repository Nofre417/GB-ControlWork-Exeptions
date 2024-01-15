using static System.Console;

namespace ControlProjectWorkWithExeptions
{
    public class ConsoleManager
    {
        Model model = new();
        DataPerson dataPerson;

        #region COMMANDS_LISTS
        List<string> commands = new()
        {
            "1 - Print commands",
            "2 - Add new person",
            "0 - End program"
        };
        List<string> commandEdit = new()
        {
            "1 - Edit full name",
            "2 - Edit date of birth",
            "3 - Edit phone number",
            "4 - Edit gender",
            "0 - Stop editing"
        };
        #endregion

        public ConsoleManager() { }

        #region WORK_WITH_CONSOLE
        public void Output(string input)
        {
            WriteLine(input);
        }

        public string Input()
        {
            return ReadLine();
        }

        public string Input(string input)
        {
            Write($"{input}: ");
            return ReadLine();
        }
        #endregion

        public void PrintCommands()
        {
            WriteLine("Program commands:");
            foreach(string command in commands)
            {
                WriteLine($"> {command}");
            }
        }
        public void PrintCommandsToEdit()
        {
            WriteLine("Editing commands:");
            foreach (string command in commandEdit)
            {
                WriteLine($"> {command}");
            }
        }

        public void ColorfulOutput(string output, string color = "White", bool space = true)
        {
            ConsoleColor consoleColor;

            if (Enum.TryParse(color, true, out consoleColor))
            {
                ForegroundColor = consoleColor;
                if (!space)
                {
                    Write($"{output}");
                }
                else
                {
                    WriteLine($"{output}");
                }
                ResetColor();
            }
        }

        public void DisplayConsoleColors()
        {
            ConsoleColor[] colors = (ConsoleColor[])Enum.GetValues(typeof(ConsoleColor));
            DisplayConsoleSpliter();
            WriteLine("All enable colors:");
            foreach (ConsoleColor color in colors)
            {
                ForegroundColor = color;
                WriteLine(color);
            }
            ResetColor();
            DisplayConsoleSpliter();
        }

        public void DisplayConsoleSpliter(char digit = '=')
        {
            WriteLine();
            for (int i = 0; i <= 50; i++)
            {
                Write(digit);
            }
            WriteLine();
        }

        public void PrintFullData(DataPerson dataPerson)
        {
            DisplayConsoleSpliter('-');
            ForegroundColor =  ConsoleColor.DarkGray;
            WriteLine($"Full name: {dataPerson.FullName}");
            WriteLine($"Date of birth: {dataPerson.DateOfBirth}");
            WriteLine($"Phone number: {dataPerson.PhoneNumber}");
            WriteLine($"Gender: {dataPerson.Gender}");
            ResetColor();
            DisplayConsoleSpliter('-');
        }

        public void ConsoleClear()
        {
            Clear();
        }

        public bool ResultOfParsing(bool result)
        {
            if (!result)
            {
                ColorfulOutput("Entered incorrect data\nPlease repeat again", "DarkRed");
                return false;
            }

            return true;
        }

        public void ProgramText()
        {
            Clear();
            ColorfulOutput("PROGRAM", "Cyan");
        }
    }
}
