using System;
using System.Data.SqlClient;
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
                var command =
                    new MySqlCommand("insert into student (PESEL,Name,Surname,Class) values (" + '"' +
                                     student.PESEL + '"' + "," + '"' + student.Name + '"' + "," + '"' +
                                     student.Surname + '"' + "," + '"' + student.Class + '"' +
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
            throw new NotImplementedException();
        }

        public void DeleteStudent(string pesel) {
            try {
                MySqlConnection.Open();
                var command = new MySqlCommand("delete from student where PESEL=" + pesel + ";");
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

    }

}