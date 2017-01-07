using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
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
                MySqlCommand command =
                    new MySqlCommand("insert into student (PESEL,Name,Surname,Class) values (" + '"' +
                                     student.PESEL + '"' + "," + '"' + student.Name.ToString() + '"' + "," + '"' +
                                     student.Surname.ToString() + '"' + "," + '"' + student.Class.ToString() + '"' +
                                     ");");
                command.Connection = MySqlConnection;
                command.Prepare();
                command.ExecuteNonQuery();
            }
            catch (SqlException exception) {
                throw exception;
            }
            finally {
                MySqlConnection?.Close();
            }
        }

        public void ModifyStudent(string pesel) {
            //delete from student where PESEL=pesel;
            throw new NotImplementedException();
        }

        public void DeleteStudent(string pesel) {
            throw new NotImplementedException();
        }

    }

}