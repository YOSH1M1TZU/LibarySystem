using System.Collections;

namespace LibarySystem.Core.Interfaces {

    internal interface IStudent : IEnumerable {

        string PESEL { get; }
        string Name { get; set; }
        string SecondName { get; set; }
        string Surname { get; set; }
        string Class { get; set; }

    }

}