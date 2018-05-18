using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Information_System_GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_LogIn_Click(object sender, EventArgs e)
        {

            MainMenu mainmenu = new MainMenu(this);
            //this.Dispose();
           
            mainmenu.Show();
           

        }

        private void Login_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            pictureBox1.Visible = false;
        }

        private void Login_Shown(object sender, EventArgs e)
        {
            //600
            //300
            int trigger = 0;
            this.Location = new Point(this.Location.X+300, this.Location.Y+150);
            for (int i = 0; i < 300; i++)
            {
                this.Size = new Size(i*2, i);
               
                if (trigger == 2)
                {
                    trigger = 0;
                    this.Location = new Point(this.Location.X - 1, this.Location.Y - 1);

                }
                else {
                    this.Location = new Point(this.Location.X - 1, this.Location.Y);
                }
                trigger++;
            }
            panel1.Visible = true;
            pictureBox1.Visible = true;
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
            label4.AutoSize = true;
            label4.Font =  new Font("Arial", 10, FontStyle.Bold);
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            // Make a Rectangle that defines the circular area.
            Rectangle rect = new Rectangle(0, 0, 52, 47);

            // Make a GraphicsPath and add the circle.
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(rect);

            // Convert the GraphicsPath into a Region.
            Region region = new Region(path);

            // Restrict the PictureBoxes to the Region.
            pictureBox1.Padding = new Padding(5);
            ToolTip tip = new ToolTip();
            tip.Show("Exit", pictureBox1, 5000);
            pictureBox1.BackColor = Color.White;
            pictureBox1.Region = region;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Padding = new Padding(0);
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Region = null;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.Arrow;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 8, FontStyle.Regular);
        }
    }
}
