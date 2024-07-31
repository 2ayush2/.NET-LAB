using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace SimpleCrudAdoNet.Models
{
    public class StudentRepository
    {
        private readonly string _connectionString;

        public StudentRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<Student> GetAllStudents()
        {
            var students = new List<Student>();
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Students", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        students.Add(new Student
                        {
                            Id = reader.GetInt32("Id"),
                            Name = reader.GetString("Name"),
                            Age = reader.GetInt32("Age")
                        });
                    }
                }
            }
            return students;
        }

        public Student GetStudentById(int id)
        {
            Student student = null;
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Students WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        student = new Student
                        {
                            Id = reader.GetInt32("Id"),
                            Name = reader.GetString("Name"),
                            Age = reader.GetInt32("Age")
                        };
                    }
                }
            }
            return student;
        }

        public void AddStudent(Student student)
        {
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO Students (Name, Age) VALUES (@Name, @Age)", conn);
                cmd.Parameters.AddWithValue("@Name", student.Name);
                cmd.Parameters.AddWithValue("@Age", student.Age);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateStudent(Student student)
        {
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE Students SET Name = @Name, Age = @Age WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Name", student.Name);
                cmd.Parameters.AddWithValue("@Age", student.Age);
                cmd.Parameters.AddWithValue("@Id", student.Id);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteStudent(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM Students WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
