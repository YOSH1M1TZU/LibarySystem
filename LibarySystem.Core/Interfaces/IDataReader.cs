using LibarySystem.Core.Objects;

namespace LibarySystem.Core.Interfaces {

    public interface IStudentReader {

        void AddStudent(Student student);
        void ModifyStudent(string pesel);
        void DeleteStudent(string pesel);

    }

}