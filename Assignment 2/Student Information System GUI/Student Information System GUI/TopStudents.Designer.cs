namespace Student_Information_System_GUI
{
    partial class TopStudents
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
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PB_Exit = new System.Windows.Forms.PictureBox();
            this.Semester = new System.Windows.Forms.Label();
            this.txt_Semester = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Exit)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(271, 33);
            this.label7.TabIndex = 7;
            this.label7.Text = "Top Three Students";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 152);
            this.dataGridView1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 294);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(707, 20);
            this.panel2.TabIndex = 10;
            // 
            // PB_Exit
            // 
            this.PB_Exit.Image = global::Student_Information_System_GUI.Properties.Resources.circled_left;
            this.PB_Exit.Location = new System.Drawing.Point(659, 0);
            this.PB_Exit.Name = "PB_Exit";
            this.PB_Exit.Size = new System.Drawing.Size(48, 48);
            this.PB_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Exit.TabIndex = 11;
            this.PB_Exit.TabStop = false;
            this.PB_Exit.Click += new System.EventHandler(this.PB_Exit_Click);
            // 
            // Semester
            // 
            this.Semester.AutoSize = true;
            this.Semester.Location = new System.Drawing.Point(12, 16);
            this.Semester.Name = "Semester";
            this.Semester.Size = new System.Drawing.Size(51, 13);
            this.Semester.TabIndex = 12;
            this.Semester.Text = "Semester";
            this.Semester.Click += new System.EventHandler(this.Semester_Click);
            // 
            // txt_Semester
            // 
            this.txt_Semester.Location = new System.Drawing.Point(82, 13);
            this.txt_Semester.Name = "txt_Semester";
            this.txt_Semester.Size = new System.Drawing.Size(134, 20);
            this.txt_Semester.TabIndex = 13;
            this.txt_Semester.TextChanged += new System.EventHandler(this.txt_Semester_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Semester);
            this.panel1.Controls.Add(this.txt_Semester);
            this.panel1.Location = new System.Drawing.Point(210, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 50);
            this.panel1.TabIndex = 14;
            // 
            // TopStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 314);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PB_Exit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TopStudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TopStudents";
            this.Load += new System.EventHandler(this.TopStudents_Load);
            this.Shown += new System.EventHandler(this.TopStudents_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Exit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox PB_Exit;
        private System.Windows.Forms.Label Semester;
        private System.Windows.Forms.TextBox txt_Semester;
        private System.Windows.Forms.Panel panel1;
    }
}