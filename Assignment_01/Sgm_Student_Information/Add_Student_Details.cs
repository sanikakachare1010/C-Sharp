using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sgm_Student_Information
{
    public partial class Frm_Stud_Details : Form
    {
        public Frm_Stud_Details()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-68RIR1L;Initial Catalog=SGM_Student_Admission_System_DB;Integrated Security=True");
        void Con_Open()
        {
           if(Con.State != ConnectionState.Open)
           {
                Con.Open();
           }
        }
        void Con_Close()
        {
           if(Con.State != ConnectionState.Closed)

           {
              Con.Close();
           }
        }
        void Clear_Controls()
        {
            tb_RollNo.Clear();
            tb_Name.Clear();
            tb_Mob_No.Clear();
            DTP_DOB.Text = "1-06-2000";
            Cmb_Course.SelectedIndex = -1;
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();
            if(tb_RollNo.Text != "" && tb_Name.Text != "" && tb_Mob_No.Text != "" && DTP_DOB.Text != "" && Cmb_Course.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "Insert Into Student_Details Values(@RN,@NM,@MNo,@DOB,@Course)";

                Cmd.Parameters.Add("RN", SqlDbType.Int).Value = tb_RollNo.Text;
                Cmd.Parameters.Add("NM", SqlDbType.VarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("MNo", SqlDbType.Decimal).Value = tb_Mob_No.Text;
                Cmd.Parameters.Add("DOB", SqlDbType.Date).Value = DTP_DOB.Text;
                Cmd.Parameters.Add("Course", SqlDbType.NVarChar).Value = Cmb_Course.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Inserted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();
               
            }
            else
            {
                MessageBox.Show("Fill All Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Con_Close();
        }

        private void btn_Ref_Click(object sender, EventArgs e)
        {
            tb_RollNo.Clear();
            tb_Name.Clear();
            tb_Mob_No.Clear();
            DTP_DOB.Text = "1-06-2000";
            Cmb_Course.SelectedIndex = -1;
        }

        private void btn_Add_New_Stud_Click(object sender, EventArgs e)
        {
            Frm_Student_List obj = new Frm_Student_List();
            obj.Show();
            this.Hide();
        }
        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            Frm_Login obj = new Frm_Login();
            obj.Show();
            this.Hide();
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsDigit(e.KeyChar)||(e.KeyChar==(char)Keys.Back)))
            {
                e.Handled = true;
            }

        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsLetter(e.KeyChar)||(e.KeyChar==(char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Only_Numbers(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsNumber(e.KeyChar)||(e.KeyChar==(char)Keys.Back)))
            {
                e.Handled = true;
            }
        }
    }
}