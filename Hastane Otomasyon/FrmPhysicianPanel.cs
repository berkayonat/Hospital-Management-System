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
    public partial class FrmPhysicianPanel : Form
    {
        public FrmPhysicianPanel()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CD8COQV;Initial Catalog=HastaneOtomasyon;Integrated Security=True");
        void AppointmentList()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT A.AppointmentId,A.Date,AT.Time,P.IdNumber,P.Name,P.Surname FROM Appointment A join AppointmentTime AT ON A.TimeId=AT.TimeId join PatientRegistration P ON A.PatientId=P.PatientId WHERE A.Date >= DATEADD(DAY, -1, GETDATE()) AND A.PhysicianId=(SELECT PhysicianId FROM Physician WHERE IdNumber='" + lblIdNo.Text + "')ORDER BY A.Date,AT.Time ASC", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmPhysicianPanel_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Physician WHERE IdNumber = '" + lblIdNo.Text + "'", con);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                lblName.Text = read["Name"].ToString();
                
            }

            con.Close();
            AppointmentList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPw.Text != "" && txtRPw.Text != "")
            {

                if (txtPw.Text == txtRPw.Text)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Physician set Password='" + txtPw.Text + "' where IdNumber='" + lblIdNo.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Password updated");
                    txtPw.Text = "";
                    txtRPw.Text = "";
                }
                else
                {
                    MessageBox.Show("Passwords do not match !");
                }
            }
            else
            {
                MessageBox.Show("Please enter password !");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult Secim = new DialogResult();

            Secim = MessageBox.Show("Do you confirm the deletion?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (Secim == DialogResult.Yes)
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from Appointment where AppointmentId = '" + dataGridView1.CurrentRow.Cells["AppointmentId"].Value.ToString() + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Appointment Deleted !");
                    AppointmentList();
                }
                else
                {
                    MessageBox.Show("Please select a valid appointment from the table below !");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT A.AppointmentId,A.Date,AT.Time,P.IdNumber,P.Name,P.Surname FROM Appointment A join AppointmentTime AT ON A.TimeId=AT.TimeId join PatientRegistration P ON A.PatientId=P.PatientId WHERE A.Date >= DATEADD(DAY, -1, GETDATE()) AND A.PhysicianId=(SELECT PhysicianId FROM Physician WHERE IdNumber='" + lblIdNo.Text + "') AND (P.Name like '%"+txtSearch.Text+ "%' OR P.IdNumber like '%" + txtSearch.Text + "%') ORDER BY A.Date,AT.Time ASC", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            if (txtSearch.Text == "")
            {
                AppointmentList();
            }
        }
    }
}

