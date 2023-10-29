
namespace Sgm_Student_Information
{
    partial class Frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.lba_headder = new System.Windows.Forms.Label();
            this.lba_username = new System.Windows.Forms.Label();
            this.lba_password = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lba_headder
            // 
            this.lba_headder.AutoSize = true;
            this.lba_headder.BackColor = System.Drawing.Color.Azure;
            this.lba_headder.Font = new System.Drawing.Font("Sitka Small", 30F);
            this.lba_headder.ForeColor = System.Drawing.Color.Navy;
            this.lba_headder.Location = new System.Drawing.Point(268, 23);
            this.lba_headder.Name = "lba_headder";
            this.lba_headder.Size = new System.Drawing.Size(256, 59);
            this.lba_headder.TabIndex = 0;
            this.lba_headder.Text = "Login Form";
            // 
            // lba_username
            // 
            this.lba_username.AutoSize = true;
            this.lba_username.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lba_username.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lba_username.ForeColor = System.Drawing.Color.Crimson;
            this.lba_username.Location = new System.Drawing.Point(168, 169);
            this.lba_username.Name = "lba_username";
            this.lba_username.Size = new System.Drawing.Size(109, 22);
            this.lba_username.TabIndex = 1;
            this.lba_username.Text = "User Name :";
            // 
            // lba_password
            // 
            this.lba_password.AutoSize = true;
            this.lba_password.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lba_password.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lba_password.ForeColor = System.Drawing.Color.Crimson;
            this.lba_password.Location = new System.Drawing.Point(168, 263);
            this.lba_password.Name = "lba_password";
            this.lba_password.Size = new System.Drawing.Size(99, 22);
            this.lba_password.TabIndex = 2;
            this.lba_password.Text = "Password :";
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(482, 173);
            this.tb_name.MaxLength = 12;
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(207, 23);
            this.tb_name.TabIndex = 1;
            // 
            // tb_password
            // 
            this.tb_password.AccessibleName = "";
            this.tb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(482, 263);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(207, 23);
            this.tb_password.TabIndex = 2;
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_submit.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.ForeColor = System.Drawing.Color.Maroon;
            this.btn_submit.Location = new System.Drawing.Point(335, 361);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(94, 38);
            this.btn_submit.TabIndex = 3;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.lba_password);
            this.Controls.Add(this.lba_username);
            this.Controls.Add(this.lba_headder);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lba_headder;
        private System.Windows.Forms.Label lba_username;
        private System.Windows.Forms.Label lba_password;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button btn_submit;
    }
}

