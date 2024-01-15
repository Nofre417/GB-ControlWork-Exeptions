using System;
using System.Text.Json;
using static System.Console;
using static System.Environment;
using static System.IO.Path;

namespace ControlProjectWorkWithExeptions
{
    public class Repository : IRepository
    {
        Model model;
        DataPerson dataPerson;
        private string filePath = Combine(CurrentDirectory, "DataPerson.json");


        Stack<DataPerson> dataPersonList = new Stack<DataPerson>();
        
        public Repository()
        {
            
        }
        
        JsonSerializerOptions options = new()
        {
            IncludeFields = true,
            PropertyNameCaseInsensitive = true,
            WriteIndented = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        };
        

        public bool save(DataPerson dataPerson)
        {
            if(!File.Exists(filePath)) 
            {
                create();
            }

            using (FileStream fileStream = new FileStream(filePath, FileMode.Append))
            {
                JsonSerializer.Serialize<DataPerson>(utf8Json: fileStream, value: dataPerson, options);
            }

            /* FOR TESTS
            Console.WriteLine($"REPOSITORY (43)>");
            Console.WriteLine(File.ReadAllText(filePath));
            Console.WriteLine($"REPOSITORY (45)>");
            */
            return true;
        }

        public bool create()
        {
            using(Stream fileStream = File.Create(filePath))
            {
                return true;
            }
        }

        
    }
}
