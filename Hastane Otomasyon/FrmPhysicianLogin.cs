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
    public partial class FrmPhysicianLogin : Form
    {
        public FrmPhysicianLogin()
        {
            InitializeComponent();
        }

        private void btnPatientLogin_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CD8COQV;Initial Catalog=HastaneOtomasyon;Integrated Security=True");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT IdNumber,Password FROM Physician WHERE IdNumber='" + txtIdNo.Text + "' AND Password='" + txtPw.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                FrmPhysicianPanel frm = new FrmPhysicianPanel();
                frm.lblIdNo.Text = txtIdNo.Text;
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
