using Students.Models;
using Students.Services;
using Students.Services.Interfaces;
using System;
using System.Windows.Forms;

namespace Students
{
    public partial class Form1 : Form
    {
        private IStudentService studentService;

        public Form1() : this(new StudentService())
        {
        }

        public Form1(IStudentService studentService)
        {
            InitializeComponent();
            this.studentService = studentService;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadStudents();
        }

        private void loadStudents()
        {
            studentsListBox.DisplayMember = "FullName";
            studentsListBox.ValueMember = "Number";
            studentsListBox.DataSource = studentService.GetAll();
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            var student = new Student
            {
                FirstName = newStudentFirstName.Text,
                LastName = newStudentLastName.Text,
                Number = Convert.ToInt32(newStudentNumber.Value)
            };
            studentService.Add(student);
            newStudentFirstName.Text = string.Empty;
            newStudentLastName.Text = string.Empty;
            newStudentAverageGrade.Text = string.Empty;
            newStudentNumber.Value = 0;
            loadStudents();
        }

        private void studentsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Student selectedStudent = (Student)studentsListBox.SelectedItem;

            studentFirstName.Text = selectedStudent.FirstName;
            studentLastName.Text = selectedStudent.LastName;
            studentNumber.Value = selectedStudent.Number;
            studentAverageGrade.Text = selectedStudent.AverageGrade.ToString();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            var student = new Student
            {
                FirstName = studentFirstName.Text,
                LastName = studentLastName.Text,
                Number = Convert.ToInt32(studentNumber.Value),
                AverageGrade = Convert.ToDouble(studentAverageGrade.Text),
            };
            studentService.Update(student);

            loadStudents();
        }

        private void showExcellentGradesButton_Click(object sender, EventArgs e)
        {
            var students = studentService.GetAllWithExcellentGrade();
            string messageBoxText = string.Empty;
            foreach (var student in students)
            {
                messageBoxText += student.FullName + "; ";
            }
            MessageBox.Show(messageBoxText);
        }
    }
}