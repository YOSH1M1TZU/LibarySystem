using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibarySystem.Core.Interfaces {

    interface IStudent {

        int ID { get; set; }
        string Name { get; set; }
        string SecondName { get; set; }
        string Surname { get; set; }
        string Class { get; set; }

    }

}