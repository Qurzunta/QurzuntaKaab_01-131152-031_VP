namespace Student_Information_System_GUI
{
    partial class DeleteStudent
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Enrollment = new System.Windows.Forms.TextBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.PB_Exit = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Exit)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Enrollment";
            // 
            // txt_Enrollment
            // 
            this.txt_Enrollment.Location = new System.Drawing.Point(130, 23);
            this.txt_Enrollment.Name = "txt_Enrollment";
            this.txt_Enrollment.Size = new System.Drawing.Size(140, 20);
            this.txt_Enrollment.TabIndex = 1;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(267, 152);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(112, 38);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // PB_Exit
            // 
            this.PB_Exit.Image = global::Student_Information_System_GUI.Properties.Resources.circled_left;
            this.PB_Exit.Location = new System.Drawing.Point(469, -1);
            this.PB_Exit.Name = "PB_Exit";
            this.PB_Exit.Size = new System.Drawing.Size(48, 48);
            this.PB_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Exit.TabIndex = 7;
            this.PB_Exit.TabStop = false;
            this.PB_Exit.Click += new System.EventHandler(this.PB_Exit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 33);
            this.label7.TabIndex = 6;
            this.label7.Text = "Delete Student";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_Enrollment);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(72, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 67);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 227);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(517, 20);
            this.panel2.TabIndex = 9;
            // 
            // DeleteStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 247);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PB_Exit);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteStudent";
            this.Load += new System.EventHandler(this.DeleteStudent_Load);
            this.Shown += new System.EventHandler(this.DeleteStudent_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Exit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Enrollment;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.PictureBox PB_Exit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}