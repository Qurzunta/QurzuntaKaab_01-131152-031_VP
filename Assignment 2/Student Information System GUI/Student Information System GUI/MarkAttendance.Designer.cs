namespace Student_Information_System_GUI
{
    partial class MarkAttendance
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
            this.btn_Submit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Semester = new System.Windows.Forms.TextBox();
            this.pnl_Setup = new System.Windows.Forms.Panel();
            this.btn_MarkAttendence = new System.Windows.Forms.Button();
            this.btn_all_present = new System.Windows.Forms.Button();
            this.btn_all_absent = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.PB_Exit = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.pnl_Setup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(365, 112);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(85, 23);
            this.btn_Submit.TabIndex = 0;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_Semester);
            this.panel1.Location = new System.Drawing.Point(159, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 42);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Semester";
            // 
            // txt_Semester
            // 
            this.txt_Semester.Location = new System.Drawing.Point(113, 8);
            this.txt_Semester.Name = "txt_Semester";
            this.txt_Semester.Size = new System.Drawing.Size(178, 20);
            this.txt_Semester.TabIndex = 1;
            // 
            // pnl_Setup
            // 
            this.pnl_Setup.Controls.Add(this.btn_MarkAttendence);
            this.pnl_Setup.Controls.Add(this.btn_all_present);
            this.pnl_Setup.Controls.Add(this.btn_all_absent);
            this.pnl_Setup.Location = new System.Drawing.Point(112, 156);
            this.pnl_Setup.Name = "pnl_Setup";
            this.pnl_Setup.Size = new System.Drawing.Size(431, 43);
            this.pnl_Setup.TabIndex = 2;
            this.pnl_Setup.Visible = false;
            // 
            // btn_MarkAttendence
            // 
            this.btn_MarkAttendence.Location = new System.Drawing.Point(260, 9);
            this.btn_MarkAttendence.Name = "btn_MarkAttendence";
            this.btn_MarkAttendence.Size = new System.Drawing.Size(148, 23);
            this.btn_MarkAttendence.TabIndex = 0;
            this.btn_MarkAttendence.Text = "Mark Attendance";
            this.btn_MarkAttendence.UseVisualStyleBackColor = true;
            this.btn_MarkAttendence.Click += new System.EventHandler(this.btn_MarkAttendence_Click);
            // 
            // btn_all_present
            // 
            this.btn_all_present.Location = new System.Drawing.Point(105, 9);
            this.btn_all_present.Name = "btn_all_present";
            this.btn_all_present.Size = new System.Drawing.Size(75, 23);
            this.btn_all_present.TabIndex = 0;
            this.btn_all_present.Text = "All Present";
            this.btn_all_present.UseVisualStyleBackColor = true;
            this.btn_all_present.Click += new System.EventHandler(this.btn_all_present_Click);
            // 
            // btn_all_absent
            // 
            this.btn_all_absent.Location = new System.Drawing.Point(24, 9);
            this.btn_all_absent.Name = "btn_all_absent";
            this.btn_all_absent.Size = new System.Drawing.Size(75, 23);
            this.btn_all_absent.TabIndex = 0;
            this.btn_all_absent.Text = "All Absent";
            this.btn_all_absent.UseVisualStyleBackColor = true;
            this.btn_all_absent.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 199);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(668, 20);
            this.panel2.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(106, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(234, 33);
            this.label7.TabIndex = 13;
            this.label7.Text = "Mark Attendance";
            // 
            // PB_Exit
            // 
            this.PB_Exit.BackColor = System.Drawing.Color.Transparent;
            this.PB_Exit.Image = global::Student_Information_System_GUI.Properties.Resources.circled_left;
            this.PB_Exit.Location = new System.Drawing.Point(0, 0);
            this.PB_Exit.Name = "PB_Exit";
            this.PB_Exit.Size = new System.Drawing.Size(48, 48);
            this.PB_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Exit.TabIndex = 6;
            this.PB_Exit.TabStop = false;
            this.PB_Exit.Click += new System.EventHandler(this.PB_Exit_Click);
            // 
            // MarkAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(685, 153);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PB_Exit);
            this.Controls.Add(this.pnl_Setup);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Submit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MarkAttendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MarkAttendance";
            this.Load += new System.EventHandler(this.MarkAttendance_Load);
            this.Shown += new System.EventHandler(this.MarkAttendance_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_Setup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Semester;
        private System.Windows.Forms.Panel pnl_Setup;
        private System.Windows.Forms.Button btn_MarkAttendence;
        private System.Windows.Forms.Button btn_all_present;
        private System.Windows.Forms.Button btn_all_absent;
        private System.Windows.Forms.PictureBox PB_Exit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
    }
}