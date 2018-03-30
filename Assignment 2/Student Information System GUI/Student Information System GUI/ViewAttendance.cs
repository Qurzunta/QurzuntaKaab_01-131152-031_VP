using Student_Information_System;
using Student_Information_System.DBOP;
using Student_Information_System.Entity;
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
    public partial class ViewAttendance : Form
    {
        int extend;

        GroupBox[] groupBox;
        RadioButton[,] radioButton;
        Label[,] label;

       

        Attendance atd;

        ArrayList aryViewAttendance;

        DBOPStudent dbop;

        public ViewAttendance()
        {
            InitializeComponent();
            extend = 0;
        }

        private void PB_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (txt_Semester.Text.ToString() != "")
            {

                aryViewAttendance = new ArrayList();
                dbop = new DBOPStudent();
                aryViewAttendance = dbop.View_Attendance(txt_Semester.Text.ToString());

                if (aryViewAttendance.Count > 0)
                {
                    //this.Size = new Size(537, 350);
                    ExtendUI();
                    GenerateAttendanceSheet(aryViewAttendance);

                }
                else
                {
                    foreach (var item in groupBox)
                    {
                        item.Visible = false;
                    }
                    ReduceUI();
                    MessageBox.Show("Semester Doesn't Have Any Attendance Marked.", "Warning Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            else {
                MessageBox.Show("Please Fill The Semester Feild.", "Warning Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ExtendUI()
        {
            if (extend == 0)
            {
                extend = 1;
                int trigger = 0;
                int a = this.Location.Y;
                for (int i = 192; i < 350; i++)
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

                for (int i = 350; i > 192; i--)
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
            label = new Label[aryStd.Count,2];


            for (int i = 0; i < aryStd.Count; i++)
            {
                groupBox[i] = new GroupBox();
                groupBox[i].Location = new Point(80, (180) + (i * 70));
                groupBox[i].Name = "groupBox" + i;
                groupBox[i].Size = new System.Drawing.Size(400, 60);
                groupBox[i].TabIndex = 0;
                groupBox[i].TabStop = false;
                //groupBox[i].Text = "groupBox1";

                atd = new Attendance();
                atd = (Attendance)aryViewAttendance[i];

                label[i,0] = new Label();
                label[i, 0].Location = new Point(80, 25);
                //label[i, 0].Name = "RadioButton" + i + "0";
               // std = (Student)aryStd[i];
                label[i, 0].Text = atd.enrollment.ToString();


                label[i, 1] = new Label();
                label[i, 1].Location = new Point(280, 25);
                //label[i, 0].Name = "RadioButton" + i + "0";
                // std = (Student)aryStd[i];
                //label[i, 1].Text = atd.enrollment.ToString();

                //this.Controls.Add(radioButton[i, 0]);

                if (atd.status == 0)
                {
                    label[i, 1].Text = "Absent";
                }
                else { label[i, 1].Text = "Present"; }


                //this.Controls.Add(radioButton[i, 1]);

                groupBox[i].Controls.Add(label[i,0]);
                groupBox[i].Controls.Add(label[i, 1]);


                this.Controls.Add(groupBox[i]);
            }
        }

        private void ViewAttendance_Load(object sender, EventArgs e)
        {
            label7.Visible = false;
            panel1.Visible = false;
            btn_Submit.Visible = false;
            PB_Exit.Visible = false;
        }

        private void ViewAttendance_Shown(object sender, EventArgs e)
        {
            for (int i = 0; i < 192; i++)
            {
                this.Size = new Size(this.Size.Width, i);
            }
            label7.Visible = true;
            panel1.Visible = true;
            btn_Submit.Visible = true;
            PB_Exit.Visible = true;
        }
    }
}
