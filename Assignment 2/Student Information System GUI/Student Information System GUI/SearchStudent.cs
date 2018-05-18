using Student_Information_System;
using Student_Information_System.DBOP;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Information_System_GUI
{
    public partial class SearchStudent : Form
    {
        DBOPStudent dbop;
        Student student;

        public SearchStudent()
        {
            InitializeComponent();
        }

        private void PB_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txt_Enrollent_TextChanged(object sender, EventArgs e)
        {
            student = new Student();
            dbop = new DBOPStudent();
            student = dbop.SearchByID(txt_Enrollent.Text.ToString());
            if (student.getenrollment() != "")
            {
                Student[] arrStudents = new Student[1];
                arrStudents[0] = student;
                DataTable dt = ConvertArrayToDataTable(arrStudents);
                dataGridView1.DataSource = dt;
            }
        }
        private DataTable ConvertArrayToDataTable(Student[] myArray)
        {
            DataTable dt = new DataTable("MyDataTable");
            dt.Columns.Add("Enrollment");
            dt.Columns.Add("Name");
            dt.Columns.Add("Semester");
            dt.Columns.Add("CGPA");
            dt.Columns.Add("Dept");
            dt.Columns.Add("University");
            foreach (Student std in myArray)
            {
                dt.Rows.Add(std.getenrollment(),std.getname(), std.getsemester(), std.getcgpa(), std.getdepartment(), std.getuniversity());
            }
            return dt;
        }

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {
            student = new Student();
            dbop = new DBOPStudent();

            ArrayList _aryStd = new ArrayList();
            _aryStd = dbop._SearchByName(txt_Name.Text.ToString());
            if (_aryStd != null)
            {
                Student[] arrStudents = new Student[_aryStd.Count];

                arrStudents = _aryStd.ToArray(typeof(Student)) as Student[];

                DataTable dt = ConvertArrayToDataTable(arrStudents);

                dataGridView2.DataSource = dt;
            }
               
        }

        private void txt_Semester_TextChanged(object sender, EventArgs e)
        {
            student = new Student();
            dbop = new DBOPStudent();

            ArrayList _aryStd = new ArrayList();
            _aryStd = dbop.SearchBySemester(txt_Semester.Text.ToString());
            if (_aryStd != null)
            {
                Student[] arrStudents = new Student[_aryStd.Count];

                arrStudents = _aryStd.ToArray(typeof(Student)) as Student[];

                DataTable dt = ConvertArrayToDataTable(arrStudents);

                dataGridView3.DataSource = dt;
            }
        }

        private void SearchStudent_Load(object sender, EventArgs e)
        {
            tabControl1.Visible = false;
            label7.Visible = false;
            PB_Exit.Visible = false;

        }

        private void SearchStudent_Shown(object sender, EventArgs e)
        {
            for (int i = 0; i < 429; i++)
            {
                this.Size = new Size(this.Size.Width, i);
            }
            PB_Exit.Visible = true;
            tabControl1.Visible = true;
            label7.Visible = true;
        }
    }
}
