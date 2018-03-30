namespace Student_Information_System_GUI
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PB_Exit = new System.Windows.Forms.PictureBox();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PB_TopStudent = new System.Windows.Forms.PictureBox();
            this.PB_MarkAttendance = new System.Windows.Forms.PictureBox();
            this.PB_DeleteStudent = new System.Windows.Forms.PictureBox();
            this.PB_SearchStudent = new System.Windows.Forms.PictureBox();
            this.PB_ViewAttendance = new System.Windows.Forms.PictureBox();
            this.PB_CreateStudent = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_TopStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_MarkAttendance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_DeleteStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_SearchStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_ViewAttendance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_CreateStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PB_Exit);
            this.panel1.Controls.Add(this.lbl_Time);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(988, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 681);
            this.panel1.TabIndex = 1;
            // 
            // PB_Exit
            // 
            this.PB_Exit.Image = global::Student_Information_System_GUI.Properties.Resources.shutdown;
            this.PB_Exit.Location = new System.Drawing.Point(191, 12);
            this.PB_Exit.Name = "PB_Exit";
            this.PB_Exit.Size = new System.Drawing.Size(73, 64);
            this.PB_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Exit.TabIndex = 3;
            this.PB_Exit.TabStop = false;
            this.PB_Exit.Click += new System.EventHandler(this.PB_Exit_Click);
            this.PB_Exit.MouseLeave += new System.EventHandler(this.PB_Exit_MouseLeave);
            this.PB_Exit.MouseHover += new System.EventHandler(this.PB_Exit_MouseHover);
            // 
            // lbl_Time
            // 
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Time.Location = new System.Drawing.Point(68, 448);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(121, 38);
            this.lbl_Time.TabIndex = 2;
            this.lbl_Time.Text = "Admin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Admin";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Blue;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 663);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(276, 18);
            this.panel4.TabIndex = 1;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Student_Information_System_GUI.Properties.Resources.name;
            this.pictureBox7.Location = new System.Drawing.Point(21, 101);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(229, 242);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 0;
            this.pictureBox7.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.PB_TopStudent);
            this.panel2.Controls.Add(this.PB_MarkAttendance);
            this.panel2.Controls.Add(this.PB_DeleteStudent);
            this.panel2.Controls.Add(this.PB_SearchStudent);
            this.panel2.Controls.Add(this.PB_ViewAttendance);
            this.panel2.Controls.Add(this.PB_CreateStudent);
            this.panel2.Location = new System.Drawing.Point(54, 210);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(788, 447);
            this.panel2.TabIndex = 2;
            // 
            // PB_TopStudent
            // 
            this.PB_TopStudent.BackColor = System.Drawing.Color.Transparent;
            this.PB_TopStudent.Image = global::Student_Information_System_GUI.Properties.Resources.student_male;
            this.PB_TopStudent.Location = new System.Drawing.Point(27, 254);
            this.PB_TopStudent.Name = "PB_TopStudent";
            this.PB_TopStudent.Size = new System.Drawing.Size(186, 175);
            this.PB_TopStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_TopStudent.TabIndex = 2;
            this.PB_TopStudent.TabStop = false;
            this.PB_TopStudent.Click += new System.EventHandler(this.PB_TopStudent_Click);
            this.PB_TopStudent.MouseLeave += new System.EventHandler(this.PB_TopStudent_MouseLeave);
            this.PB_TopStudent.MouseHover += new System.EventHandler(this.PB_TopStudent_MouseHover);
            // 
            // PB_MarkAttendance
            // 
            this.PB_MarkAttendance.BackColor = System.Drawing.Color.Transparent;
            this.PB_MarkAttendance.Image = global::Student_Information_System_GUI.Properties.Resources.curriculum;
            this.PB_MarkAttendance.Location = new System.Drawing.Point(298, 254);
            this.PB_MarkAttendance.Name = "PB_MarkAttendance";
            this.PB_MarkAttendance.Size = new System.Drawing.Size(186, 175);
            this.PB_MarkAttendance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_MarkAttendance.TabIndex = 2;
            this.PB_MarkAttendance.TabStop = false;
            this.PB_MarkAttendance.Click += new System.EventHandler(this.PB_MarkAttendance_Click);
            this.PB_MarkAttendance.MouseLeave += new System.EventHandler(this.PB_MarkAttendance_MouseLeave);
            this.PB_MarkAttendance.MouseHover += new System.EventHandler(this.PB_MarkAttendance_MouseHover);
            // 
            // PB_DeleteStudent
            // 
            this.PB_DeleteStudent.BackColor = System.Drawing.Color.Transparent;
            this.PB_DeleteStudent.Image = global::Student_Information_System_GUI.Properties.Resources.delete_property;
            this.PB_DeleteStudent.Location = new System.Drawing.Point(574, 28);
            this.PB_DeleteStudent.Name = "PB_DeleteStudent";
            this.PB_DeleteStudent.Size = new System.Drawing.Size(186, 175);
            this.PB_DeleteStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_DeleteStudent.TabIndex = 2;
            this.PB_DeleteStudent.TabStop = false;
            this.PB_DeleteStudent.Click += new System.EventHandler(this.PB_DeleteStudent_Click);
            this.PB_DeleteStudent.MouseLeave += new System.EventHandler(this.PB_DeleteStudent_MouseLeave);
            this.PB_DeleteStudent.MouseHover += new System.EventHandler(this.PB_DeleteStudent_MouseHover);
            // 
            // PB_SearchStudent
            // 
            this.PB_SearchStudent.BackColor = System.Drawing.Color.Transparent;
            this.PB_SearchStudent.Image = global::Student_Information_System_GUI.Properties.Resources.find_user_male;
            this.PB_SearchStudent.Location = new System.Drawing.Point(298, 28);
            this.PB_SearchStudent.Name = "PB_SearchStudent";
            this.PB_SearchStudent.Size = new System.Drawing.Size(186, 175);
            this.PB_SearchStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_SearchStudent.TabIndex = 2;
            this.PB_SearchStudent.TabStop = false;
            this.PB_SearchStudent.Click += new System.EventHandler(this.PB_SearchStudent_Click);
            this.PB_SearchStudent.MouseLeave += new System.EventHandler(this.PB_SearchStudent_MouseLeave);
            this.PB_SearchStudent.MouseHover += new System.EventHandler(this.PB_SearchStudent_MouseHover);
            // 
            // PB_ViewAttendance
            // 
            this.PB_ViewAttendance.BackColor = System.Drawing.Color.Transparent;
            this.PB_ViewAttendance.Image = global::Student_Information_System_GUI.Properties.Resources.open_document;
            this.PB_ViewAttendance.Location = new System.Drawing.Point(574, 254);
            this.PB_ViewAttendance.Name = "PB_ViewAttendance";
            this.PB_ViewAttendance.Size = new System.Drawing.Size(186, 175);
            this.PB_ViewAttendance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_ViewAttendance.TabIndex = 2;
            this.PB_ViewAttendance.TabStop = false;
            this.PB_ViewAttendance.Click += new System.EventHandler(this.PB_ViewAttendance_Click);
            this.PB_ViewAttendance.MouseLeave += new System.EventHandler(this.PB_ViewAttendance_MouseLeave);
            this.PB_ViewAttendance.MouseHover += new System.EventHandler(this.PB_ViewAttendance_MouseHover);
            // 
            // PB_CreateStudent
            // 
            this.PB_CreateStudent.BackColor = System.Drawing.Color.Transparent;
            this.PB_CreateStudent.Image = global::Student_Information_System_GUI.Properties.Resources.add_user_male;
            this.PB_CreateStudent.Location = new System.Drawing.Point(27, 28);
            this.PB_CreateStudent.Name = "PB_CreateStudent";
            this.PB_CreateStudent.Size = new System.Drawing.Size(186, 175);
            this.PB_CreateStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_CreateStudent.TabIndex = 1;
            this.PB_CreateStudent.TabStop = false;
            this.PB_CreateStudent.Click += new System.EventHandler(this.PB_CreateStudent_Click);
            this.PB_CreateStudent.MouseLeave += new System.EventHandler(this.PB_CreateStudent_MouseLeave);
            this.PB_CreateStudent.MouseHover += new System.EventHandler(this.PB_CreateStudent_MouseHover);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Blue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 663);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(988, 18);
            this.panel3.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(671, 79);
            this.label2.TabIndex = 4;
            this.label2.Text = "Student Information System";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_TopStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_MarkAttendance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_DeleteStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_SearchStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_ViewAttendance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_CreateStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox PB_CreateStudent;
        private System.Windows.Forms.PictureBox PB_TopStudent;
        private System.Windows.Forms.PictureBox PB_MarkAttendance;
        private System.Windows.Forms.PictureBox PB_DeleteStudent;
        private System.Windows.Forms.PictureBox PB_SearchStudent;
        private System.Windows.Forms.PictureBox PB_ViewAttendance;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox PB_Exit;
        private System.Windows.Forms.Label label2;
    }
}