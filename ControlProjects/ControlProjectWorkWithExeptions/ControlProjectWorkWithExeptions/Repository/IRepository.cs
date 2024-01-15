using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlProjectWorkWithExeptions
{
    public interface IRepository
    {
        bool create();
        bool save(DataPerson dataPerson);

    }
}
