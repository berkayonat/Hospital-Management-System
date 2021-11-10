using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Hastane_Otomasyon
{
    public partial class FrmPatientRegistration : Form
    {
        public FrmPatientRegistration()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-CD8COQV;Initial Catalog=HastaneOtomasyon;Integrated Security=True");
        private void button4_Click(object sender, EventArgs e)
        {
            if (txtPw.Text != "" && txtIdNo.Text != "")
            {
            
            if (txtPw.Text == txtRPw.Text)
            {


                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into PatientRegistration (Name,Surname,IdNumber,PhoneNumber,Email,Gender,DateOfBirth,Password) values('" + txtName.Text + "','" + txtSurname.Text + "','" + txtIdNo.Text + "','" + mskdTxtPhone.Text + "','" + txtEmail.Text + "','" + txtGender.Text + "','" + dTPDOB.Value.ToString("yyyy-MM-dd") + "','" + txtPw.Text + "')", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Registration Successful");
                this.Hide();
                FrmPatientLogin fr = new FrmPatientLogin();
                fr.Show();
            } 
            else
            {
                MessageBox.Show("Passwords do not match !");
            }
            
            }
            else
            {
                MessageBox.Show("Please enter password and ID number !");

            }
        }
        private void FrmPatientRegistration_Load(object sender, EventArgs e)
        {

        }
    }
}
