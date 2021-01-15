using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany
{
    namespace MyApp
    {
        interface IManager
        {
            void control();
            void organize();
            List<IWorker> listWorkers { get; set; }
        }
    }
}
