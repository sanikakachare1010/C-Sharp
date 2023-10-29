
namespace Sgm_Student_Information
{
    partial class Frm_Stud_Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Stud_Details));
            this.lbl_Stud_Info = new System.Windows.Forms.Label();
            this.lba_Stud_Name = new System.Windows.Forms.Label();
            this.lbl_Roll_No = new System.Windows.Forms.Label();
            this.tb_RollNo = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lbl_Mob_No = new System.Windows.Forms.Label();
            this.tb_Mob_No = new System.Windows.Forms.TextBox();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.lbl_course = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.btn_Ref = new System.Windows.Forms.Button();
            this.Cmb_Course = new System.Windows.Forms.ComboBox();
            this.btn_Add_New_Stud = new System.Windows.Forms.Button();
            this.DTP_DOB = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lbl_Stud_Info
            // 
            this.lbl_Stud_Info.AutoSize = true;
            this.lbl_Stud_Info.BackColor = System.Drawing.Color.Azure;
            this.lbl_Stud_Info.Font = new System.Drawing.Font("Sitka Small", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stud_Info.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Stud_Info.Location = new System.Drawing.Point(207, 25);
            this.lbl_Stud_Info.Name = "lbl_Stud_Info";
            this.lbl_Stud_Info.Size = new System.Drawing.Size(425, 59);
            this.lbl_Stud_Info.TabIndex = 0;
            this.lbl_Stud_Info.Text = "Add Student Details";
            // 
            // lba_Stud_Name
            // 
            this.lba_Stud_Name.AutoSize = true;
            this.lba_Stud_Name.Location = new System.Drawing.Point(133, 199);
            this.lba_Stud_Name.Name = "lba_Stud_Name";
            this.lba_Stud_Name.Size = new System.Drawing.Size(0, 15);
            this.lba_Stud_Name.TabIndex = 1;
            // 
            // lbl_Roll_No
            // 
            this.lbl_Roll_No.AutoSize = true;
            this.lbl_Roll_No.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Roll_No.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Roll_No.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Roll_No.Location = new System.Drawing.Point(124, 177);
            this.lbl_Roll_No.Name = "lbl_Roll_No";
            this.lbl_Roll_No.Size = new System.Drawing.Size(79, 22);
            this.lbl_Roll_No.TabIndex = 2;
            this.lbl_Roll_No.Text = "Roll No ";
            // 
            // tb_RollNo
            // 
            this.tb_RollNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_RollNo.Location = new System.Drawing.Point(483, 176);
            this.tb_RollNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_RollNo.MaxLength = 5;
            this.tb_RollNo.Name = "tb_RollNo";
            this.tb_RollNo.Size = new System.Drawing.Size(296, 23);
            this.tb_RollNo.TabIndex = 1;
            this.tb_RollNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Name.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Name.Location = new System.Drawing.Point(132, 237);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(61, 22);
            this.lbl_Name.TabIndex = 4;
            this.lbl_Name.Text = "Name ";
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(483, 236);
            this.tb_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_Name.MaxLength = 80;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(296, 23);
            this.tb_Name.TabIndex = 2;
            this.tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            // 
            // lbl_Mob_No
            // 
            this.lbl_Mob_No.AutoSize = true;
            this.lbl_Mob_No.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Mob_No.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mob_No.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Mob_No.Location = new System.Drawing.Point(132, 299);
            this.lbl_Mob_No.Name = "lbl_Mob_No";
            this.lbl_Mob_No.Size = new System.Drawing.Size(141, 22);
            this.lbl_Mob_No.TabIndex = 6;
            this.lbl_Mob_No.Text = "Mobile Number ";
            // 
            // tb_Mob_No
            // 
            this.tb_Mob_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mob_No.Location = new System.Drawing.Point(483, 298);
            this.tb_Mob_No.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_Mob_No.MaxLength = 10;
            this.tb_Mob_No.Name = "tb_Mob_No";
            this.tb_Mob_No.Size = new System.Drawing.Size(296, 23);
            this.tb_Mob_No.TabIndex = 3;
            this.tb_Mob_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numbers);
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.AutoSize = true;
            this.lbl_DOB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_DOB.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DOB.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_DOB.Location = new System.Drawing.Point(132, 364);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(56, 22);
            this.lbl_DOB.TabIndex = 9;
            this.lbl_DOB.Text = "DOB ";
            // 
            // lbl_course
            // 
            this.lbl_course.AutoSize = true;
            this.lbl_course.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_course.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_course.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_course.Location = new System.Drawing.Point(132, 409);
            this.lbl_course.Name = "lbl_course";
            this.lbl_course.Size = new System.Drawing.Size(71, 22);
            this.lbl_course.TabIndex = 10;
            this.lbl_course.Text = "Course ";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Snow;
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_Save.Location = new System.Drawing.Point(375, 502);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(105, 38);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_LogOut.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogOut.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_LogOut.Location = new System.Drawing.Point(801, 3);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(81, 31);
            this.btn_LogOut.TabIndex = 9;
            this.btn_LogOut.Text = "Log out";
            this.btn_LogOut.UseVisualStyleBackColor = false;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // btn_Ref
            // 
            this.btn_Ref.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Ref.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ref.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_Ref.Location = new System.Drawing.Point(60, 502);
            this.btn_Ref.Name = "btn_Ref";
            this.btn_Ref.Size = new System.Drawing.Size(97, 38);
            this.btn_Ref.TabIndex = 7;
            this.btn_Ref.Text = "Refresh";
            this.btn_Ref.UseVisualStyleBackColor = false;
            this.btn_Ref.Click += new System.EventHandler(this.btn_Ref_Click);
            // 
            // Cmb_Course
            // 
            this.Cmb_Course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Course.FormattingEnabled = true;
            this.Cmb_Course.Items.AddRange(new object[] {
            "BCA",
            "BCS",
            "BSc.C.S",
            "MCA",
            "MCS",
            "MSc.C.S"});
            this.Cmb_Course.Location = new System.Drawing.Point(483, 419);
            this.Cmb_Course.Name = "Cmb_Course";
            this.Cmb_Course.Size = new System.Drawing.Size(296, 23);
            this.Cmb_Course.TabIndex = 5;
            // 
            // btn_Add_New_Stud
            // 
            this.btn_Add_New_Stud.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Add_New_Stud.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_New_Stud.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_Add_New_Stud.Location = new System.Drawing.Point(694, 502);
            this.btn_Add_New_Stud.Name = "btn_Add_New_Stud";
            this.btn_Add_New_Stud.Size = new System.Drawing.Size(123, 38);
            this.btn_Add_New_Stud.TabIndex = 11;
            this.btn_Add_New_Stud.Text = " Student List";
            this.btn_Add_New_Stud.UseVisualStyleBackColor = false;
            this.btn_Add_New_Stud.Click += new System.EventHandler(this.btn_Add_New_Stud_Click);
            // 
            // DTP_DOB
            // 
            this.DTP_DOB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_DOB.Location = new System.Drawing.Point(483, 365);
            this.DTP_DOB.MaxDate = new System.DateTime(2006, 6, 1, 0, 0, 0, 0);
            this.DTP_DOB.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.DTP_DOB.Name = "DTP_DOB";
            this.DTP_DOB.Size = new System.Drawing.Size(296, 26);
            this.DTP_DOB.TabIndex = 12;
            this.DTP_DOB.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // Frm_Stud_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.DTP_DOB);
            this.Controls.Add(this.btn_Add_New_Stud);
            this.Controls.Add(this.Cmb_Course);
            this.Controls.Add(this.btn_Ref);
            this.Controls.Add(this.btn_LogOut);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.lbl_course);
            this.Controls.Add(this.lbl_DOB);
            this.Controls.Add(this.tb_Mob_No);
            this.Controls.Add(this.lbl_Mob_No);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.tb_RollNo);
            this.Controls.Add(this.lbl_Roll_No);
            this.Controls.Add(this.lba_Stud_Name);
            this.Controls.Add(this.lbl_Stud_Info);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Stud_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Student_Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Stud_Info;
        private System.Windows.Forms.Label lba_Stud_Name;
        private System.Windows.Forms.Label lbl_Roll_No;
        private System.Windows.Forms.TextBox tb_RollNo;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label lbl_Mob_No;
        private System.Windows.Forms.TextBox tb_Mob_No;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.Label lbl_course;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.Button btn_Ref;
        private System.Windows.Forms.ComboBox Cmb_Course;
        private System.Windows.Forms.Button btn_Add_New_Stud;
        private System.Windows.Forms.DateTimePicker DTP_DOB;
    }
}