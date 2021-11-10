
namespace Hastane_Otomasyon
{
    partial class FrmPatientRegistration
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
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPw = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdNo = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.mskdTxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dTPDOB = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnHastaKayit = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRPw = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(161, 78);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(149, 22);
            this.txtSurname.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(63, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(86, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(161, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(149, 22);
            this.txtName.TabIndex = 1;
            // 
            // txtPw
            // 
            this.txtPw.Location = new System.Drawing.Point(161, 315);
            this.txtPw.Name = "txtPw";
            this.txtPw.Size = new System.Drawing.Size(149, 22);
            this.txtPw.TabIndex = 8;
            this.txtPw.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(56, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(49, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "ID Number";
            // 
            // txtIdNo
            // 
            this.txtIdNo.Location = new System.Drawing.Point(161, 117);
            this.txtIdNo.MaxLength = 11;
            this.txtIdNo.Name = "txtIdNo";
            this.txtIdNo.Size = new System.Drawing.Size(149, 22);
            this.txtIdNo.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(161, 390);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 48);
            this.button4.TabIndex = 15;
            this.button4.Text = "Register";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(19, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Phone Number";
            // 
            // mskdTxtPhone
            // 
            this.mskdTxtPhone.Location = new System.Drawing.Point(161, 156);
            this.mskdTxtPhone.Mask = "(999) 000-0000";
            this.mskdTxtPhone.Name = "mskdTxtPhone";
            this.mskdTxtPhone.Size = new System.Drawing.Size(149, 22);
            this.mskdTxtPhone.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(88, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(161, 194);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(149, 22);
            this.txtEmail.TabIndex = 5;
            // 
            // txtGender
            // 
            this.txtGender.FormattingEnabled = true;
            this.txtGender.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.txtGender.Location = new System.Drawing.Point(161, 236);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(93, 24);
            this.txtGender.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(75, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Gender";
            // 
            // dTPDOB
            // 
            this.dTPDOB.Location = new System.Drawing.Point(161, 274);
            this.dTPDOB.Name = "dTPDOB";
            this.dTPDOB.Size = new System.Drawing.Size(200, 22);
            this.dTPDOB.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(34, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Date of Birth";
            // 
            // BtnHastaKayit
            // 
            this.BtnHastaKayit.Location = new System.Drawing.Point(132, 363);
            this.BtnHastaKayit.Name = "BtnHastaKayit";
            this.BtnHastaKayit.Size = new System.Drawing.Size(83, 40);
            this.BtnHastaKayit.TabIndex = 14;
            this.BtnHastaKayit.Text = "Kayıt";
            this.BtnHastaKayit.UseVisualStyleBackColor = true;
            this.BtnHastaKayit.Click += new System.EventHandler(this.button4_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(-2, 350);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Repeat Password";
            // 
            // txtRPw
            // 
            this.txtRPw.Location = new System.Drawing.Point(161, 348);
            this.txtRPw.Name = "txtRPw";
            this.txtRPw.Size = new System.Drawing.Size(149, 22);
            this.txtRPw.TabIndex = 10;
            this.txtRPw.UseSystemPasswordChar = true;
            // 
            // FrmPatientRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(369, 450);
            this.Controls.Add(this.txtRPw);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dTPDOB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.mskdTxtPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtPw);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdNo);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPatientRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient Registration";
            this.Load += new System.EventHandler(this.FrmPatientRegistration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdNo;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskdTxtPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox txtGender;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dTPDOB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnHastaKayit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRPw;
    }
}