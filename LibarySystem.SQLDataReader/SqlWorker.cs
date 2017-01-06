using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using LibarySystem.Core.Interfaces;
using LibarySystem.Core.Objects;
using MySql.Data.MySqlClient;

namespace LibarySystem.SQLDataReader {

    public class SqlWorker : IStudentReader {

        public MySqlConnection MySqlConnection = new MySqlConnection("user id=root;" +
                                                                     "password=root; " + 
                                                                     "server=localhost;" +
                                                                     "database=mydb; ");

        public void AddStudent(Student student) {
            try {
                MySqlConnection.Open();
                SqlCommand command = new SqlCommand("insert into student (PESEL,Name,Surname,Class,DateOfBirth) values" +
                                                    " ("+ student.PESEL +"," + student.Name + "," + student.Surname + "," + student.Class + "," + student.DateOfBirth + ")");
            }
            catch (SqlException exception) {
                throw exception;
            }
        }

        public void ModifyStudent(string pesel) {
            throw new NotImplementedException();
        }

        public void DeleteStudent(string pesel) {
            throw new NotImplementedException();
        }

    }

}