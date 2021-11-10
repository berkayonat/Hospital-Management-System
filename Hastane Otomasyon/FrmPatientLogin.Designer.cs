
namespace Hastane_Otomasyon
{
    partial class FrmPatientLogin
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
            this.btnPatientLogin = new System.Windows.Forms.Button();
            this.txtIdNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPw = new System.Windows.Forms.TextBox();
            this.btnPatientRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPatientLogin
            // 
            this.btnPatientLogin.Location = new System.Drawing.Point(97, 139);
            this.btnPatientLogin.Name = "btnPatientLogin";
            this.btnPatientLogin.Size = new System.Drawing.Size(70, 40);
            this.btnPatientLogin.TabIndex = 3;
            this.btnPatientLogin.Text = "Login";
            this.btnPatientLogin.UseVisualStyleBackColor = true;
            this.btnPatientLogin.Click += new System.EventHandler(this.btnHastaGiris_Click);
            // 
            // txtIdNo
            // 
            this.txtIdNo.Location = new System.Drawing.Point(110, 58);
            this.txtIdNo.MaxLength = 11;
            this.txtIdNo.Name = "txtIdNo";
            this.txtIdNo.Size = new System.Drawing.Size(136, 22);
            this.txtIdNo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(14, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(21, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // txtPw
            // 
            this.txtPw.Location = new System.Drawing.Point(110, 98);
            this.txtPw.Name = "txtPw";
            this.txtPw.Size = new System.Drawing.Size(136, 22);
            this.txtPw.TabIndex = 2;
            this.txtPw.UseSystemPasswordChar = true;
            // 
            // btnPatientRegister
            // 
            this.btnPatientRegister.Location = new System.Drawing.Point(176, 139);
            this.btnPatientRegister.Name = "btnPatientRegister";
            this.btnPatientRegister.Size = new System.Drawing.Size(70, 40);
            this.btnPatientRegister.TabIndex = 4;
            this.btnPatientRegister.Text = "Register";
            this.btnPatientRegister.UseVisualStyleBackColor = true;
            this.btnPatientRegister.Click += new System.EventHandler(this.btnHastaKayit_Click);
            // 
            // FrmPatientLogin
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.btnPatientRegister);
            this.Controls.Add(this.txtPw);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdNo);
            this.Controls.Add(this.btnPatientLogin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPatientLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnPatientLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPw;
        private System.Windows.Forms.Button btnPatientRegister;
        public System.Windows.Forms.TextBox txtIdNo;
    }
}