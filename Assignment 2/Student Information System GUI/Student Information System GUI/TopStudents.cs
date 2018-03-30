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
    public partial class TopStudents : Form
    {

        DBOPStudent dbop;
        Student student;

        public TopStudents()
        {
            InitializeComponent();
        }

        private void PB_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void TopStudents_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            label7.Visible = false;
            dataGridView1.Visible = false;
            PB_Exit.Visible = false;
        }

        private void txt_Semester_TextChanged(object sender, EventArgs e)
        {
            student = new Student();
            dbop = new DBOPStudent();

            ArrayList _aryStd = new ArrayList();
            _aryStd = dbop.Top3Student(txt_Semester.Text.ToString());
            if (_aryStd != null)
            {
                Student[] arrStudents = new Student[_aryStd.Count];

                arrStudents = _aryStd.ToArray(typeof(Student)) as Student[];

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
                dt.Rows.Add(std.getenrollment(), std.getname(), std.getsemester(), std.getcgpa(), std.getdepartment(), std.getuniversity());
            }
            return dt;
        }

        private void Semester_Click(object sender, EventArgs e)
        {

        }

        private void TopStudents_Shown(object sender, EventArgs e)
        {
            for (int i = 0; i < 314; i++)
            {
                this.Size = new Size(this.Size.Width, i);
            }
            panel1.Visible = true;
            label7.Visible = true;
            dataGridView1.Visible = true;
            PB_Exit.Visible = true;
        }
    }
}
