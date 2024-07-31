using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using SimpleCrudAdoNet.Models;

namespace SimpleCrudAdoNet.DataAccess
{
    public class StudentDataAccessLayer
    {
        private readonly string connectionString = "Server=localhost;Database=ayush;Uid=root;Pwd=;";

        public IEnumerable<Student> GetAllStudents()
        {
            var students = new List<Student>();

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Students", con);
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var student = new Student
                    {
                        Id = reader.GetInt32("Id"),
                        Name = reader.GetString("Name"),
                        Age = reader.GetInt32("Age"),
                        Address = reader.GetString("Address")
                    };
                    students.Add(student);
                }
                con.Close();
            }

            return students;
        }

        public void AddStudent(Student student)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO Students (Name, Age, Address) VALUES (@Name, @Age, @Address)";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", student.Name);
                cmd.Parameters.AddWithValue("@Age", student.Age);
                cmd.Parameters.AddWithValue("@Address", student.Address);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void UpdateStudent(Student student)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                string query = "UPDATE Students SET Name=@Name, Age=@Age, Address=@Address WHERE Id=@Id";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", student.Id);
                cmd.Parameters.AddWithValue("@Name", student.Name);
                cmd.Parameters.AddWithValue("@Age", student.Age);
                cmd.Parameters.AddWithValue("@Address", student.Address);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void DeleteStudent(int id)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                string query = "DELETE FROM Students WHERE Id=@Id";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", id);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
