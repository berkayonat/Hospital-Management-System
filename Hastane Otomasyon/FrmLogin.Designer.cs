
namespace Hastane_Otomasyon
{
    partial class FrmLogin
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPatient = new System.Windows.Forms.Button();
            this.btnPhysician = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPatient
            // 
            this.btnPatient.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPatient.Location = new System.Drawing.Point(71, 103);
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.Size = new System.Drawing.Size(179, 130);
            this.btnPatient.TabIndex = 0;
            this.btnPatient.Text = "Patient\r\n";
            this.btnPatient.UseVisualStyleBackColor = false;
            this.btnPatient.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPhysician
            // 
            this.btnPhysician.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnPhysician.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPhysician.Location = new System.Drawing.Point(256, 103);
            this.btnPhysician.Name = "btnPhysician";
            this.btnPhysician.Size = new System.Drawing.Size(179, 130);
            this.btnPhysician.TabIndex = 1;
            this.btnPhysician.Text = "Physician";
            this.btnPhysician.UseVisualStyleBackColor = false;
            this.btnPhysician.Click += new System.EventHandler(this.btnDoktorGiris_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdmin.Location = new System.Drawing.Point(441, 103);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(179, 130);
            this.btnAdmin.TabIndex = 2;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = false;
            // 
            // FrmLogin
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(707, 345);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnPhysician);
            this.Controls.Add(this.btnPatient);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospital Management System";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPatient;
        private System.Windows.Forms.Button btnPhysician;
        private System.Windows.Forms.Button btnAdmin;
    }
}

