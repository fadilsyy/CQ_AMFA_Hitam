namespace PraktikumADO
{
    partial class Form1
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnHitungMK = new System.Windows.Forms.Button();
            this.btnHitungMhs = new System.Windows.Forms.Button();
            this.btnHitungDsn = new System.Windows.Forms.Button();
            this.btnUpdateMK = new System.Windows.Forms.Button();
            this.btnInsertPS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHasil = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(151, 328);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(145, 29);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(675, 328);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(145, 29);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update Mhs";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnHitungMK
            // 
            this.btnHitungMK.Location = new System.Drawing.Point(502, 328);
            this.btnHitungMK.Name = "btnHitungMK";
            this.btnHitungMK.Size = new System.Drawing.Size(145, 29);
            this.btnHitungMK.TabIndex = 2;
            this.btnHitungMK.Text = "Hitung MK";
            this.btnHitungMK.UseVisualStyleBackColor = true;
            this.btnHitungMK.Click += new System.EventHandler(this.btnHitungMK_Click);
            // 
            // btnHitungMhs
            // 
            this.btnHitungMhs.Location = new System.Drawing.Point(326, 328);
            this.btnHitungMhs.Name = "btnHitungMhs";
            this.btnHitungMhs.Size = new System.Drawing.Size(145, 29);
            this.btnHitungMhs.TabIndex = 3;
            this.btnHitungMhs.Text = "Hitung Mhs";
            this.btnHitungMhs.UseVisualStyleBackColor = true;
            this.btnHitungMhs.Click += new System.EventHandler(this.btnHitungMhs_Click);
            // 
            // btnHitungDsn
            // 
            this.btnHitungDsn.Location = new System.Drawing.Point(326, 374);
            this.btnHitungDsn.Name = "btnHitungDsn";
            this.btnHitungDsn.Size = new System.Drawing.Size(145, 29);
            this.btnHitungDsn.TabIndex = 4;
            this.btnHitungDsn.Text = "Hitung Dsn";
            this.btnHitungDsn.UseVisualStyleBackColor = true;
            this.btnHitungDsn.Click += new System.EventHandler(this.btnHitungDsn_Click);
            // 
            // btnUpdateMK
            // 
            this.btnUpdateMK.Location = new System.Drawing.Point(502, 374);
            this.btnUpdateMK.Name = "btnUpdateMK";
            this.btnUpdateMK.Size = new System.Drawing.Size(145, 29);
            this.btnUpdateMK.TabIndex = 5;
            this.btnUpdateMK.Text = "Update MK";
            this.btnUpdateMK.UseVisualStyleBackColor = true;
            this.btnUpdateMK.Click += new System.EventHandler(this.btnUpdateMK_Click);
            // 
            // btnInsertPS
            // 
            this.btnInsertPS.Location = new System.Drawing.Point(675, 374);
            this.btnInsertPS.Name = "btnInsertPS";
            this.btnInsertPS.Size = new System.Drawing.Size(145, 29);
            this.btnInsertPS.TabIndex = 6;
            this.btnInsertPS.Text = "Insert PS";
            this.btnInsertPS.UseVisualStyleBackColor = true;
            this.btnInsertPS.Click += new System.EventHandler(this.btnInsertPS_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // txtHasil
            // 
            this.txtHasil.Location = new System.Drawing.Point(326, 178);
            this.txtHasil.Name = "txtHasil";
            this.txtHasil.Size = new System.Drawing.Size(494, 26);
            this.txtHasil.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 467);
            this.Controls.Add(this.txtHasil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInsertPS);
            this.Controls.Add(this.btnUpdateMK);
            this.Controls.Add(this.btnHitungDsn);
            this.Controls.Add(this.btnHitungMhs);
            this.Controls.Add(this.btnHitungMK);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnHitungMK;
        private System.Windows.Forms.Button btnHitungMhs;
        private System.Windows.Forms.Button btnHitungDsn;
        private System.Windows.Forms.Button btnUpdateMK;
        private System.Windows.Forms.Button btnInsertPS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHasil;
    }
}

