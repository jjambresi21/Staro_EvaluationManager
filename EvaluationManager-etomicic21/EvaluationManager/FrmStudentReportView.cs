using EvaluationManager.Models;
using EvaluationManager.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluationManager {
    public partial class FrmStudentReportView : Form {
        public FrmStudentReportView() {
            InitializeComponent();
        }

        private void FrmStudentReportView_Load(object sender, EventArgs e) {
            List<StudentReportView> reports = new List<StudentReportView>();
            List<Student> students = StudentRepository.GetStudents();

            foreach (var student in students) {
                reports.Add(new StudentReportView(student));
            }

            dgvReports.DataSource = reports;
         
        }
    }
}
