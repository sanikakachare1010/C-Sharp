using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sgm_Student_Information
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }
        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (tb_name.Text == "Admin" && tb_password.Text == "a123")
            {
                MessageBox.Show("Login Successful","WELLCOME");

                Frm_Stud_Details obj = new Frm_Stud_Details();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed, Enter Correct Username/Password...", "Failure");

            }
            tb_name.Clear();
            tb_password.Clear();
            tb_name.Focus();
        }
    }
}
 