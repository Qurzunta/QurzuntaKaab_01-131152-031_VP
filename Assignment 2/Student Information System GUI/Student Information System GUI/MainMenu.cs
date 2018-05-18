using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Information_System_GUI
{
    public partial class MainMenu : Form
    {
        Form fm;
        public MainMenu()
        {
            InitializeComponent();

            string path = @"..\..\file.txt";
            StreamWriter obj = new StreamWriter(path, true);
            obj.AutoFlush = true;
            //obj.WriteLine("Hello");
            obj.Close();

        }
        public MainMenu(Form form)
        {
            InitializeComponent();

            string path = @"..\..\file.txt";
            StreamWriter obj = new StreamWriter(path, true);
            obj.AutoFlush = true;
            //obj.WriteLine("Hello");
            obj.Close();

            fm = form;
            fm.Hide();

        }
        private void Control_PictureBox_UI_On(PictureBox pictureBox,String tooltip)
        {
            // Make a Rectangle that defines the circular area.
            Rectangle rect = new Rectangle(0, 0, 186, 175);

            // Make a GraphicsPath and add the circle.
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(rect);

            // Convert the GraphicsPath into a Region.
            Region region = new Region(path);

            // Restrict the PictureBoxes to the Region.
            pictureBox.Padding = new Padding(25);
            ToolTip tip = new ToolTip();
            tip.Show(tooltip, pictureBox, 5000);
            pictureBox.BackColor = Color.White;
            pictureBox.Region = region;
        }
        private void Control_PictureBox_UI_Off(PictureBox pictureBox)
        {
            pictureBox.Padding = new Padding(0);
            pictureBox.BackColor = Color.Transparent;
            pictureBox.Region = null;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_Time.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
           this.Dispose();
           
        }

        private void PB_CreateStudent_MouseHover(object sender, EventArgs e)
        {
            Control_PictureBox_UI_On(PB_CreateStudent, "Create Student");
        }

        private void PB_CreateStudent_MouseLeave(object sender, EventArgs e)
        {
            Control_PictureBox_UI_Off(PB_CreateStudent);
        }

        private void PB_SearchStudent_MouseHover(object sender, EventArgs e)
        {
            Control_PictureBox_UI_On(PB_SearchStudent, "Search Student");
        }

        private void PB_SearchStudent_MouseLeave(object sender, EventArgs e)
        {
            Control_PictureBox_UI_Off(PB_SearchStudent);
        }

        private void PB_DeleteStudent_MouseHover(object sender, EventArgs e)
        {
            Control_PictureBox_UI_On(PB_DeleteStudent, "Delete Student");
        }

        private void PB_DeleteStudent_MouseLeave(object sender, EventArgs e)
        {
            Control_PictureBox_UI_Off(PB_DeleteStudent);
        }

        private void PB_TopStudent_MouseHover(object sender, EventArgs e)
        {
            Control_PictureBox_UI_On(PB_TopStudent, "Top 3 Students");
        }

        private void PB_TopStudent_MouseLeave(object sender, EventArgs e)
        {
            Control_PictureBox_UI_Off(PB_TopStudent);
        }

        private void PB_MarkAttendance_MouseHover(object sender, EventArgs e)
        {
            Control_PictureBox_UI_On(PB_MarkAttendance, "Mark Attendance");
        }

        private void PB_MarkAttendance_MouseLeave(object sender, EventArgs e)
        {
            Control_PictureBox_UI_Off(PB_MarkAttendance);
        }

        private void PB_ViewAttendance_MouseHover(object sender, EventArgs e)
        {
            Control_PictureBox_UI_On(PB_ViewAttendance, "View Attendance");
        }

        private void PB_ViewAttendance_MouseLeave(object sender, EventArgs e)
        {
            Control_PictureBox_UI_Off(PB_ViewAttendance);
        }

        private void PB_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            fm.Show();
        }

        private void PB_Exit_MouseHover(object sender, EventArgs e)
        {
            // Make a Rectangle that defines the circular area.
            Rectangle rect = new Rectangle(0, 0, 73, 64);

            // Make a GraphicsPath and add the circle.
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(rect);

            // Convert the GraphicsPath into a Region.
            Region region = new Region(path);

            // Restrict the PictureBoxes to the Region.
            PB_Exit.Padding = new Padding(5);
            ToolTip tip = new ToolTip();
            tip.Show("Exit", PB_Exit, 5000);
            PB_Exit.BackColor = Color.White;
            PB_Exit.Region = region;
        }

        private void PB_Exit_MouseLeave(object sender, EventArgs e)
        {
            Control_PictureBox_UI_Off(PB_Exit);
        }

        private void PB_CreateStudent_Click(object sender, EventArgs e)
        {
            CreateStudent obj = new CreateStudent();
            obj.ShowDialog();
        }

        private void PB_DeleteStudent_Click(object sender, EventArgs e)
        {
            DeleteStudent obj = new DeleteStudent();
            obj.ShowDialog();
        }

        private void PB_SearchStudent_Click(object sender, EventArgs e)
        {
            SearchStudent obj = new SearchStudent();
            obj.ShowDialog();
        }

        private void PB_TopStudent_Click(object sender, EventArgs e)
        {
            TopStudents obj = new TopStudents();
            obj.ShowDialog();
        }

        private void PB_MarkAttendance_Click(object sender, EventArgs e)
        {
            MarkAttendance obj = new MarkAttendance();
            obj.ShowDialog();
        }

        private void PB_ViewAttendance_Click(object sender, EventArgs e)
        {
            ViewAttendance obj = new ViewAttendance();
            obj.ShowDialog();
        }

      
    }
}
