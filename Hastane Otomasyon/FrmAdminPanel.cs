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
    public partial class FrmAdminPanel : Form
    {
        public FrmAdminPanel()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CD8COQV;Initial Catalog=HastaneOtomasyon;Integrated Security=True");

        void DepartmentList()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Department", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView3.DataSource = dt;
            con.Close();
        }
        void AppointmentList()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT A.AppointmentId,A.Date,AT.Time,P.IdNumber,P.Name,P.Surname FROM Appointment A join AppointmentTime AT ON A.TimeId=AT.TimeId join PatientRegistration P ON A.PatientId=P.PatientId WHERE A.Date >= DATEADD(DAY, -1, GETDATE()) AND A.PhysicianId=(SELECT PhysicianId FROM Physician WHERE Name='" + comboBox2.Text + "')ORDER BY A.Date,AT.Time ASC", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }

        void PhysicianList()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Physician", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            AppointmentList();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmAdminPanel_Load(object sender, EventArgs e)
        {

            this.departmentTableAdapter.Fill(this.hastaneOtomasyonDataSet2.Department);
            PhysicianList();
            DepartmentList();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
            txtIdNo.Text = dataGridView1.CurrentRow.Cells["IdNumber"].Value.ToString();     
            mskdTxtPhone.Text = dataGridView1.CurrentRow.Cells["PhoneNumber"].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
            txtGender.Text = dataGridView1.CurrentRow.Cells["Gender"].Value.ToString();
            dTPDOB.Text = dataGridView1.CurrentRow.Cells["DateOfBirth"].Value.ToString();
            txtPw.Text = dataGridView1.CurrentRow.Cells["Password"].Value.ToString();

            txtDepartment.Text = "";
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT DepartmentName FROM Department WHERE DepartmentId =  '" + dataGridView1.CurrentRow.Cells["DepartmentId"].Value.ToString() + "'", con);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                txtDepartment.SelectedValue = (read["DepartmentName"].ToString());
            }
            con.Close();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.departmentTableAdapter.FillBy(this.hastaneOtomasyonDataSet2.Department);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPw.Text != "" && txtIdNo.Text != "" && txtName.Text != "" && txtDepartment.Text != "")
            {

                if (txtPw.Text == txtRPw.Text)
                {
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Physician WHERE IdNumber = '" + txtIdNo.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    con.Close();
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("There is a physician with this ID number.");
                    }
                    else
                    {


                        con.Open();
                        SqlCommand cmd = new SqlCommand("insert into Physician (Name,IdNumber,PhoneNumber,Email,Gender,DateOfBirth,DepartmentId,Password) values('" + txtName.Text + "','" + txtIdNo.Text + "','" + mskdTxtPhone.Text + "','" + txtEmail.Text + "','" + txtGender.Text + "','" + dTPDOB.Value.ToString("yyyy-MM-dd") + "',(SELECT DepartmentId FROM Department WHERE DepartmentName = '" + txtDepartment.Text + "'),'" + txtPw.Text + "')", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Registration Successful");
                        PhysicianList();
                    }
                }
                else
                {
                    MessageBox.Show("Passwords do not match !");
                }

            }
            else
            {
                MessageBox.Show("Please fill Password, ID number and Name fields !");

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtPw.Text != "" && txtIdNo.Text != "" && txtName.Text != "" && txtDepartment.Text != "")
            {

                if (txtPw.Text == txtRPw.Text)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Physician set Name='" + txtName.Text + "',PhoneNumber='" + mskdTxtPhone.Text + "',Email='" + txtEmail.Text + "',Gender='" + txtGender.Text + "',DateOfBirth='" + dTPDOB.Value.ToString("yyyy-MM-dd") + "',DepartmentId=(SELECT DepartmentId FROM Department WHERE DepartmentName = '" + txtDepartment.Text + "'),Password='" + txtPw.Text + "' where IdNumber='" + txtIdNo.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record updated");
                    PhysicianList();
                }
                else
                {
                    MessageBox.Show("Passwords do not match !");
                }
            }
            else
            {
                MessageBox.Show("Please fill Password, ID number and Name fields !");

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult Secim = new DialogResult();

            Secim = MessageBox.Show("Do you confirm the deletion?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (Secim == DialogResult.Yes)
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from Physician where PhysicianId = '" + dataGridView1.CurrentRow.Cells["PhysicianId"].Value.ToString() + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Deleted !");
                    PhysicianList();
                }
                else
                {
                    MessageBox.Show("Please select a valid physician from the table !");
                }
            }

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Name FROM Physician WHERE DepartmentId =  (SELECT DepartmentId FROM Department WHERE DepartmentName ='" + comboBox1.Text + "')", con);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                comboBox2.Items.Add(read["Name"].ToString());
            }
            con.Close();
        }

        private void btnDelete2_Click(object sender, EventArgs e)
        {
            DialogResult Secim = new DialogResult();

            Secim = MessageBox.Show("Do you confirm the deletion?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (Secim == DialogResult.Yes)
            {
                if (dataGridView2.SelectedRows.Count == 1)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from Appointment where AppointmentId = '" + dataGridView2.CurrentRow.Cells["AppointmentId"].Value.ToString() + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Deleted !");
                    AppointmentList();
                }
                else
                {
                    MessageBox.Show("Please select a valid appointment from the table !");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtDpName.Text != "")
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Department WHERE DepartmentName = '" + txtDpName.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("There is a department with this name.");
                }
                else
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Department (DepartmentName) values('" + txtDpName.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Registration Successful");
                    DepartmentList();
                }
            }
            else
            {
                MessageBox.Show("Please fill the Department Name field !");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtDpName.Text != "")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Department set DepartmentName='" + txtDpName.Text + "' WHERE DepartmentId = '"+ txtDpId.Text +"' ", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record updated");
                DepartmentList();
            }
            else
            {
                MessageBox.Show("Please fill the Department Name field !");
            }
        }

        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDpName.Text = dataGridView3.CurrentRow.Cells["DepartmentName"].Value.ToString();
            txtDpId.Text = dataGridView3.CurrentRow.Cells["DepartmentId"].Value.ToString();
        }
    }
}
