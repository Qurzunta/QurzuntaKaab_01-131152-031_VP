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
    public partial class MarkAttendance : Form
    {
        int extend;
        ArrayList aryStd;
        DBOPStudent dbop;

        GroupBox[] groupBox;
        RadioButton[,] radioButton;
        Label[] label;

        int[] attendance;
        String _Semester;


        public MarkAttendance()
        {
            InitializeComponent();
            extend = 0;
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_Semester.Text.ToString() != "")
            {
                _Semester = txt_Semester.Text.ToString();
                pnl_Setup.Visible = false;
                try
                {
                    for (int i = 0; i < aryStd.Count; i++)
                    {
                        this.Controls.Remove(groupBox[i]);
                    }

                }
                catch (Exception)
                {
                }

                aryStd = new ArrayList();
                dbop = new DBOPStudent();
                aryStd = dbop.SearchBySemester(txt_Semester.Text.ToString());

                if (aryStd.Count > 0)
                {
                    ExtendUI();
                    pnl_Setup.Visible = true;
                    GenerateAttendanceSheet(aryStd);
                }
                else
                {

                    ReduceUI();

                    MessageBox.Show("Doesn't Exist.", "Warning Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            
        }
            else {
                MessageBox.Show("Please Fill the Semester Feild.", "Warning Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void ExtendUI()
        {
            if (extend == 0)
            {
                extend = 1;
                int trigger = 0;
                int a = this.Location.Y;
                for (int i = 185; i < 460; i++)
                {
                    this.Size = new Size(651, i);
                    if (trigger == 3)
                    {
                        a = a - 1;
                        trigger = 0;
                    }
                    this.Location = new Point(this.Location.X, a);
                    trigger++;
                }
            }
        }
        private void ReduceUI()
        {
            if (extend == 1)
            {
                int trigger = 0;
                int a = this.Location.Y;

                for (int i = 460; i > 185; i--)
                {
                    this.Size = new Size(651, i);
                    if (trigger == 3)
                    {
                        a = a + 1;
                        trigger = 0;
                    }
                    this.Location = new Point(this.Location.X, a);
                    trigger++;
                }
                extend = 0;
            }
            
        }

        private void GenerateAttendanceSheet(ArrayList aryStd)
        {
            Student std = new Student();
            groupBox = new GroupBox[aryStd.Count];
            radioButton = new RadioButton[aryStd.Count, 2];
            label = new Label[aryStd.Count];


            for (int i = 0; i < aryStd.Count; i++)
            {
                groupBox[i] = new GroupBox();
                groupBox[i].Location = new Point(60, (200) + (i * 70));
                groupBox[i].Name = "groupBox" + i;
                groupBox[i].Size = new System.Drawing.Size(500, 60);
                groupBox[i].TabIndex = 0;
                groupBox[i].TabStop = false;
                //groupBox[i].Text = "groupBox1";

                label[i] = new Label();
                label[i].Location = new Point(80, 25);
                label[i].Name = "RadioButton" + i + "0";
                std = (Student)aryStd[i];
                label[i].Text = std.getenrollment();
                this.Controls.Add(radioButton[i, 0]);



                radioButton[i, 0] = new RadioButton();

                radioButton[i, 0].Location = new Point(230, 20);
                radioButton[i, 0].Name = "RadioButton" + i + "0";
                radioButton[i, 0].Text = "Absent";
                this.Controls.Add(radioButton[i, 0]);

                radioButton[i, 1] = new RadioButton();
                radioButton[i, 1].Location = new Point(350, 20);
                radioButton[i, 1].Name = "RadioButton" + i + "1";
                radioButton[i, 1].Checked = true;
                radioButton[i, 1].Text = "Present";
                this.Controls.Add(radioButton[i, 1]);

                groupBox[i].Controls.Add(label[i]);
                groupBox[i].Controls.Add(radioButton[i, 0]);
                groupBox[i].Controls.Add(radioButton[i, 1]);

                this.Controls.Add(groupBox[i]);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < aryStd.Count; i++)
            {
                radioButton[i, 0].Checked = true;
            }
            
        }

        private void btn_all_present_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < aryStd.Count; i++)
            {
                radioButton[i, 1].Checked = true;
            }
        }

        private void PB_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_MarkAttendence_Click(object sender, EventArgs e)
        {

            attendance = new int[aryStd.Count];

            for (int i = 0; i < aryStd.Count; i++)
            {
                if (radioButton[i, 0].Checked == true)
                {
                    attendance[i] = 0;
                }
                else {
                    attendance[i] = 1;
                }
            }

            bool result = dbop.Mark_Attendance(_Semester, attendance);
            if (result.Equals(true))
            {
                MessageBox.Show("Attendance Has Been Marked Successfully!", "Success Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
                MessageBox.Show("Something Went Wrong", "Warning Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);



        }

        private void MarkAttendance_Load(object sender, EventArgs e)
        {
            PB_Exit.Visible = false;
            txt_Semester.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void MarkAttendance_Shown(object sender, EventArgs e)
        {
            
            int trigger = 0;
            int a = this.Location.Y;
            for (int i = 0; i < 185; i++)
            {
                this.Size = new Size(651, i);
                if (trigger == 3)
                {
                    a = a - 1;
                    trigger = 0;
                }
                this.Location = new Point(this.Location.X, a);
                trigger++;
            }
            PB_Exit.Visible = true;
            txt_Semester.Visible = true;
            panel1.Visible = true;
            panel2.Visible = true;
        }
    }
}
