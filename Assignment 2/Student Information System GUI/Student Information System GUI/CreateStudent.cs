using Student_Information_System;
using Student_Information_System.DBOP;
using System;
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
    public partial class CreateStudent : Form
    {
        DBOPStudent dbop = new DBOPStudent();
        Student student;

        public CreateStudent()
        {
            InitializeComponent();
        }

        private void PB_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (true)
            {
                student = new Student(txt_Enrollment.Text.ToString(), txt_Name.Text.ToString(), txt_Semester.Text.ToString(),double.Parse(txt_CGPA.Text.ToString()), txt_Dept.Text.ToString(), txt_University.Text.ToString());
                bool result = dbop.Add_Student(student);
                if (result.Equals(true))
                {
                    MessageBox.Show("Profile Has Been Created Successfully!", "Success Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                    MessageBox.Show("Enrollment Already Exist", "Warning Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                
            }
            else
            {
                MessageBox.Show("Please Fill All The Feilds", "Warning Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CreateStudent_Load(object sender, EventArgs e)
        {
            PB_Exit.Visible = false;
            panel1.Visible = false;
            label7.Visible = false;
            button1.Visible = false;
        }

        private void CreateStudent_Shown(object sender, EventArgs e)
        {
            for (int i = 0; i < 355; i++)
            {
                this.Size = new Size(this.Size.Width, i);
            }
            PB_Exit.Visible =true;
            panel1.Visible = true;
            panel2.Visible = true;
            label7.Visible = true;
            button1.Visible = true;

        }
    }
}
