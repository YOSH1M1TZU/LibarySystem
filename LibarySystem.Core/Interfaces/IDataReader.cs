using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibarySystem.Core.Objects;

namespace LibarySystem.Core.Interfaces {

    public interface IStudentReader {

        void AddStudent(Student student);
        void ModifyStudent(string pesel);
        void DeleteStudent(string pesel);

    }

}