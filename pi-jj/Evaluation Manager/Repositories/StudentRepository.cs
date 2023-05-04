using DBLayer;
using Evaluation_Manager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluation_Manager.Repositories {
    public static class StudentRepository {
        public static Student GetStudent(int it) {
            Student student = null;
            DB.OpenConnection();
            var dr = DB.GetDataReader($"SELECT * FROM Students WHERE Id = + {id}");
            if(dr.HasRows) {
                dr.Read();
                student = new Student() {
                    Id = int.Parse(dr["Id"].ToString()),
                    FirstName = dr["FirstName"].ToString(),
                    LastName = dr["LastName"].ToString(),
                };
            }
            DB.CloseConnection();
            return student;
        }
    }
}
