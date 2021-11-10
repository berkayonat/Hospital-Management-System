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
    public partial class FrmPatientLogin : Form
    {
        public FrmPatientLogin()
        {
            InitializeComponent();
        }
        
        private void btnHastaKayit_Click(object sender, EventArgs e)
        {
            FrmPatientRegistration fr = new FrmPatientRegistration();
            fr.Show();
            
        }

        private void btnHastaGiris_Click(object sender, EventArgs e)
        {
            FrmPatientPanel frm = new FrmPatientPanel();
            frm.txtIdNo.Text = txtIdNo.Text;
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CD8COQV;Initial Catalog=HastaneOtomasyon;Integrated Security=True");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT IdNumber,Password FROM PatientRegistration WHERE IdNumber='" + txtIdNo.Text + "' AND Password='" + txtPw.Text + "'", con);
            DataTable dt = new DataTable(); 
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {              
                this.Hide();                
                frm.Show();               
            }
            else
            {
                 MessageBox.Show("Invalid ID Number or Password !");
            }
            con.Close();

            
        }
    }
}
