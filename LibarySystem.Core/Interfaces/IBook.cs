using System.Collections;

namespace LibarySystem.Core.Interfaces {

    internal interface IBook : IEnumerable {

        int Id { get; }
        string Name { get; set; }
        string Author { get; set; }
        bool IsLend { get; set; }

    }

}