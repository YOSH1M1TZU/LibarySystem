using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibarySystem.Core.Interfaces {

    interface IBook : IEnumerable {

        int ID { get; }
        string Name { get; set; }
        string Author { get; set; }
        int ReleaseDate { get; set; }

    }

}