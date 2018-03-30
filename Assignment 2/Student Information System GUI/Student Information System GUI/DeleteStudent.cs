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
    public partial class DeleteStudent : Form
    {
        DBOPStudent dbop = new DBOPStudent();

        public DeleteStudent()
        {
            InitializeComponent();
        }

        private void PB_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            bool isDeleted = dbop.Delete_Student(txt_Enrollment.Text.ToString());
            if (isDeleted == true)
            {
                MessageBox.Show("Profile Has Been Deleted Successfully!", "Success Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
                MessageBox.Show("Enrollment Doesn't Exist", "Warning Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
        }

        private void DeleteStudent_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            label7.Visible = false;
            btn_Delete.Visible = false;
            PB_Exit.Visible = false;
        }

        private void DeleteStudent_Shown(object sender, EventArgs e)
        {
            for (int i = 0; i < 248; i++)
            {
                this.Size = new Size(this.Size.Width, i);
            }
            panel1.Visible = true;
            label7.Visible = true;
            btn_Delete.Visible = true;
            PB_Exit.Visible = true;
        }
    }
}
