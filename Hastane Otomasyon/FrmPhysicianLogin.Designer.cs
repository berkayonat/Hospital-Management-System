
namespace Hastane_Otomasyon
{
    partial class FrmPhysicianLogin
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
            this.txtPw = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdNo = new System.Windows.Forms.TextBox();
            this.btnPhysicianLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPw
            // 
            this.txtPw.Location = new System.Drawing.Point(108, 99);
            this.txtPw.Name = "txtPw";
            this.txtPw.Size = new System.Drawing.Size(136, 22);
            this.txtPw.TabIndex = 6;
            this.txtPw.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(19, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID Number";
            // 
            // txtIdNo
            // 
            this.txtIdNo.Location = new System.Drawing.Point(108, 59);
            this.txtIdNo.MaxLength = 11;
            this.txtIdNo.Name = "txtIdNo";
            this.txtIdNo.Size = new System.Drawing.Size(136, 22);
            this.txtIdNo.TabIndex = 5;
            // 
            // btnPhysicianLogin
            // 
            this.btnPhysicianLogin.Location = new System.Drawing.Point(174, 141);
            this.btnPhysicianLogin.Name = "btnPhysicianLogin";
            this.btnPhysicianLogin.Size = new System.Drawing.Size(70, 40);
            this.btnPhysicianLogin.TabIndex = 9;
            this.btnPhysicianLogin.Text = "Login";
            this.btnPhysicianLogin.UseVisualStyleBackColor = true;
            this.btnPhysicianLogin.Click += new System.EventHandler(this.btnPatientLogin_Click);
            // 
            // FrmPhysicianLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.txtPw);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdNo);
            this.Controls.Add(this.btnPhysicianLogin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPhysicianLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Physician Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPw;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtIdNo;
        private System.Windows.Forms.Button btnPhysicianLogin;
    }
}