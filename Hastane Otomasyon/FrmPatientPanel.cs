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
    public partial class FrmPatientPanel : Form
    {

        public FrmPatientPanel()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CD8COQV;Initial Catalog=HastaneOtomasyon;Integrated Security=True");
        void AppointmentCheck()
        {
            con.Open();
            SqlDataAdapter sda2 = new SqlDataAdapter("SELECT * FROM Appointment WHERE PhysicianId = (SELECT PhysicianId FROM Physician WHERE Name ='" + comboBox2.Text + "') AND Date = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' AND TimeId = (SELECT TimeId FROM AppointmentTime WHERE Time = '" + button9.Text + "' ) ", con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            if (dt2.Rows.Count > 0)
            {
                button9.BackColor = Color.Crimson;
                button9.Enabled = false;
            }
            else
            {
                button9.BackColor = Color.SpringGreen;
                button9.Enabled = true;
            }
            SqlDataAdapter sda3 = new SqlDataAdapter("SELECT * FROM Appointment WHERE PhysicianId = (SELECT PhysicianId FROM Physician WHERE Name ='" + comboBox2.Text + "') AND Date = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' AND TimeId = (SELECT TimeId FROM AppointmentTime WHERE Time = '" + button10.Text + "' ) ", con);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);
            if (dt3.Rows.Count > 0)
            {
                button10.BackColor = Color.Crimson;
                button10.Enabled = false;
            }
            else
            {
                button10.BackColor = Color.SpringGreen;
                button10.Enabled = true;
            }
            SqlDataAdapter sda4 = new SqlDataAdapter("SELECT * FROM Appointment WHERE PhysicianId = (SELECT PhysicianId FROM Physician WHERE Name ='" + comboBox2.Text + "') AND Date = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' AND TimeId = (SELECT TimeId FROM AppointmentTime WHERE Time = '" + button11.Text + "' ) ", con);
            DataTable dt4 = new DataTable();
            sda4.Fill(dt4);
            if (dt4.Rows.Count > 0)
            {
                button11.BackColor = Color.Crimson;
                button11.Enabled = false;
            }
            else
            {
                button11.BackColor = Color.SpringGreen;
                button11.Enabled = true;
            }
            SqlDataAdapter sda5 = new SqlDataAdapter("SELECT * FROM Appointment WHERE PhysicianId = (SELECT PhysicianId FROM Physician WHERE Name ='" + comboBox2.Text + "') AND Date = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' AND TimeId = (SELECT TimeId FROM AppointmentTime WHERE Time = '" + button13.Text + "' ) ", con);
            DataTable dt5 = new DataTable();
            sda5.Fill(dt5);
            if (dt5.Rows.Count > 0)
            {
                button13.BackColor = Color.Crimson;
                button13.Enabled = false;
            }
            else
            {
                button13.BackColor = Color.SpringGreen;
                button13.Enabled = true;
            }
            SqlDataAdapter sda6 = new SqlDataAdapter("SELECT * FROM Appointment WHERE PhysicianId = (SELECT PhysicianId FROM Physician WHERE Name ='" + comboBox2.Text + "') AND Date = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' AND TimeId = (SELECT TimeId FROM AppointmentTime WHERE Time = '" + button14.Text + "' ) ", con);
            DataTable dt6 = new DataTable();
            sda6.Fill(dt6);
            if (dt6.Rows.Count > 0)
            {
                button14.BackColor = Color.Crimson;
                button14.Enabled = false;
            }
            else
            {
                button14.BackColor = Color.SpringGreen;
                button14.Enabled = true;
            }
            SqlDataAdapter sda7 = new SqlDataAdapter("SELECT * FROM Appointment WHERE PhysicianId = (SELECT PhysicianId FROM Physician WHERE Name ='" + comboBox2.Text + "') AND Date = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' AND TimeId = (SELECT TimeId FROM AppointmentTime WHERE Time = '" + button15.Text + "' ) ", con);
            DataTable dt7 = new DataTable();
            sda7.Fill(dt7);
            if (dt7.Rows.Count > 0)
            {
                button15.BackColor = Color.Crimson;
                button15.Enabled = false;
            }
            else
            {
                button15.BackColor = Color.SpringGreen;
                button15.Enabled = true;
            }
            SqlDataAdapter sda8 = new SqlDataAdapter("SELECT * FROM Appointment WHERE PhysicianId = (SELECT PhysicianId FROM Physician WHERE Name ='" + comboBox2.Text + "') AND Date = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' AND TimeId = (SELECT TimeId FROM AppointmentTime WHERE Time = '" + button16.Text + "' ) ", con);
            DataTable dt8 = new DataTable();
            sda8.Fill(dt8);
            if (dt8.Rows.Count > 0)
            {
                button16.BackColor = Color.Crimson;
                button16.Enabled = false;
            }
            else
            {
                button16.BackColor = Color.SpringGreen;
                button16.Enabled = true;
            }
            SqlDataAdapter sda9 = new SqlDataAdapter("SELECT * FROM Appointment WHERE PhysicianId = (SELECT PhysicianId FROM Physician WHERE Name ='" + comboBox2.Text + "') AND Date = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' AND TimeId = (SELECT TimeId FROM AppointmentTime WHERE Time = '" + button17.Text + "' ) ", con);
            DataTable dt9 = new DataTable();
            sda9.Fill(dt9);
            if (dt9.Rows.Count > 0)
            {
                button17.BackColor = Color.Crimson;
                button17.Enabled = false;
            }
            else
            {
                button17.BackColor = Color.SpringGreen;
                button17.Enabled = true;
            }
            txtTime.Text = "";
            con.Close();
        }
        
        void AppointmentList()
        {
            con.Open();
            SqlDataAdapter sda17 = new SqlDataAdapter("SELECT A.AppointmentId,A.Date,AT.Time,PHY.Name AS Physician,D.DepartmentName AS Department FROM Appointment A join AppointmentTime AT ON A.TimeId=AT.TimeId join Physician PHY ON A.PhysicianId=PHY.PhysicianId join Department D ON PHY.DepartmentId=D.DepartmentId WHERE A.Date >= GETDATE() AND A.PatientId=(SELECT PatientId FROM PatientRegistration WHERE IdNumber='" + txtIdNo.Text + "')ORDER BY A.Date ASC", con);
            DataTable dt17 = new DataTable();
            sda17.Fill(dt17);
            dataGridView1.DataSource = dt17;
            con.Close();
        }

        private void PatientPanel_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'hastaneOtomasyonDataSet2.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.hastaneOtomasyonDataSet2.Department);

            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM PatientRegistration WHERE IdNumber = '" + txtIdNo.Text + "'", con);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                txtName.Text = read["Name"].ToString();
                txtSurname.Text = read["Surname"].ToString();
                mskdTxtPhone.Text = read["PhoneNumber"].ToString();
                txtEmail.Text = read["Email"].ToString();
                txtGender.Text = read["Gender"].ToString();
                dTPDOB.Text = read["DateOfBirth"].ToString();
            }

            con.Close();
            AppointmentList();
            dateTimePicker1.MinDate = DateTime.Now;

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtPw.Text != "" && txtIdNo.Text != "")
            {

                if (txtPw.Text == txtRPw.Text)
                {
                    con.Open();
                    SqlCommand cmd2 = new SqlCommand("UPDATE PatientRegistration set Name='" + txtName.Text + "',Surname='" + txtSurname.Text + "',PhoneNumber='" + mskdTxtPhone.Text + "',Email='" + txtEmail.Text + "',Gender='" + txtGender.Text + "',DateOfBirth='" + dTPDOB.Value.ToString("yyyy-MM-dd") + "',Password='" + txtPw.Text + "' where IdNumber='" + txtIdNo.Text + "'", con);
                    cmd2.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Registration updated");
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            con.Open();
            SqlCommand cmd3 = new SqlCommand("SELECT Name FROM Physician WHERE DepartmentId =  (SELECT DepartmentId FROM Department WHERE DepartmentName ='" + comboBox1.Text + "')", con);
            SqlDataReader read = cmd3.ExecuteReader();
            while (read.Read())
            {
                comboBox2.Items.Add(read["Name"].ToString());
            }
            con.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtTime.Text = button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtTime.Text = button10.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtTime.Text = button11.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtTime.Text = button13.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtTime.Text = button14.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtTime.Text = button15.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtTime.Text = button16.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            txtTime.Text = button17.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            AppointmentCheck();
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            AppointmentCheck();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && comboBox2.Text != "" && dateTimePicker1.Text != "" && txtTime.Text != "")
            {
                con.Open();
                SqlDataAdapter sda18 = new SqlDataAdapter("SELECT * FROM Appointment WHERE Date='" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "'AND TimeId = (SELECT TimeId FROM AppointmentTime WHERE Time = '" + txtTime.Text + "') AND PatientId = (SELECT PatientId FROM PatientRegistration WHERE IdNumber = '" + txtIdNo.Text + "') ", con);
                DataTable dt18 = new DataTable();
                sda18.Fill(dt18);
                if (dt18.Rows.Count > 0)
                {
                    MessageBox.Show("You have another appointment on the same date !");
                }               
                else
                {
                    
                    SqlCommand cmd4 = new SqlCommand("insert into Appointment (Date,TimeId,PatientId,PhysicianId) values('" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "',(SELECT TimeId FROM AppointmentTime WHERE Time = '" + txtTime.Text + "'),(SELECT PatientId FROM PatientRegistration WHERE IdNumber = '" + txtIdNo.Text + "'),(SELECT PhysicianId FROM Physician WHERE Name = '" + comboBox2.Text + "'))", con);
                    cmd4.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Appointment created");

                    if (txtTime.Text == button9.Text)
                    {
                        button9.BackColor = Color.Crimson;
                        button9.Enabled = false;
                    }
                    else if (txtTime.Text == button10.Text)
                    {
                        button10.BackColor = Color.Crimson;
                        button10.Enabled = false;
                    }
                    else if (txtTime.Text == button11.Text)
                    {
                        button11.BackColor = Color.Crimson;
                        button11.Enabled = false;
                    }
                    else if (txtTime.Text == button13.Text)
                    {
                        button13.BackColor = Color.Crimson;
                        button13.Enabled = false;
                    }
                    else if (txtTime.Text == button14.Text)
                    {
                        button14.BackColor = Color.Crimson;
                        button14.Enabled = false;
                    }
                    else if (txtTime.Text == button15.Text)
                    {
                        button15.BackColor = Color.Crimson;
                        button15.Enabled = false;
                    }
                    else if (txtTime.Text == button16.Text)
                    {
                        button16.BackColor = Color.Crimson;
                        button16.Enabled = false;
                    }
                    else
                    {
                        button17.BackColor = Color.Crimson;
                        button17.Enabled = false;
                    }
                    txtTime.Text = "";
                    AppointmentList();
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Please fill in the required fields !");
            }

            

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                con.Open();
                SqlCommand cmd5 = new SqlCommand("delete from Appointment where AppointmentId = '" + dataGridView1.CurrentRow.Cells["AppointmentId"].Value.ToString() + "'", con);
                cmd5.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Appointment Deleted !");
                AppointmentCheck();
                AppointmentList();
            }
            else
            {
                MessageBox.Show("Please select a valid appointment from the table below !");
            }
        }
    }
}

