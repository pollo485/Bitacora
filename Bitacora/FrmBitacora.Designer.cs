namespace Bitacora
{
    partial class FrmBitacora
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CBActivar = new System.Windows.Forms.CheckBox();
            this.txtSSID = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.CBWPA = new System.Windows.Forms.CheckBox();
            this.CBPSK = new System.Windows.Forms.CheckBox();
            this.CBWPS = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnArchivo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "SSID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // CBActivar
            // 
            this.CBActivar.AutoSize = true;
            this.CBActivar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBActivar.Location = new System.Drawing.Point(532, 39);
            this.CBActivar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBActivar.Name = "CBActivar";
            this.CBActivar.Size = new System.Drawing.Size(177, 29);
            this.CBActivar.TabIndex = 2;
            this.CBActivar.Text = "Activar 5Ghz";
            this.CBActivar.UseVisualStyleBackColor = true;
            this.CBActivar.CheckedChanged += new System.EventHandler(this.CBActivar_CheckedChanged);
            // 
            // txtSSID
            // 
            this.txtSSID.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSSID.Location = new System.Drawing.Point(83, 8);
            this.txtSSID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSSID.Name = "txtSSID";
            this.txtSSID.Size = new System.Drawing.Size(427, 32);
            this.txtSSID.TabIndex = 3;
            this.txtSSID.TextChanged += new System.EventHandler(this.txtSSID_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(148, 67);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(361, 32);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // CBWPA
            // 
            this.CBWPA.AutoSize = true;
            this.CBWPA.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBWPA.Location = new System.Drawing.Point(45, 108);
            this.CBWPA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBWPA.Name = "CBWPA";
            this.CBWPA.Size = new System.Drawing.Size(88, 29);
            this.CBWPA.TabIndex = 5;
            this.CBWPA.Text = "WPA";
            this.CBWPA.UseVisualStyleBackColor = true;
            this.CBWPA.CheckedChanged += new System.EventHandler(this.CBWPA_CheckedChanged);
            // 
            // CBPSK
            // 
            this.CBPSK.AutoSize = true;
            this.CBPSK.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBPSK.Location = new System.Drawing.Point(217, 108);
            this.CBPSK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBPSK.Name = "CBPSK";
            this.CBPSK.Size = new System.Drawing.Size(78, 29);
            this.CBPSK.TabIndex = 6;
            this.CBPSK.Text = "PSK";
            this.CBPSK.UseVisualStyleBackColor = true;
            this.CBPSK.CheckedChanged += new System.EventHandler(this.CBPSK_CheckedChanged);
            // 
            // CBWPS
            // 
            this.CBWPS.AutoSize = true;
            this.CBWPS.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBWPS.Location = new System.Drawing.Point(467, 108);
            this.CBWPS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBWPS.Name = "CBWPS";
            this.CBWPS.Size = new System.Drawing.Size(86, 29);
            this.CBWPS.TabIndex = 7;
            this.CBWPS.Text = "WPS";
            this.CBWPS.UseVisualStyleBackColor = true;
            this.CBWPS.CheckedChanged += new System.EventHandler(this.CBWPS_CheckedChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(11, 139);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(902, 294);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // btnArchivo
            // 
            this.btnArchivo.Location = new System.Drawing.Point(657, 108);
            this.btnArchivo.Name = "btnArchivo";
            this.btnArchivo.Size = new System.Drawing.Size(75, 23);
            this.btnArchivo.TabIndex = 9;
            this.btnArchivo.UseVisualStyleBackColor = true;
            this.btnArchivo.Click += new System.EventHandler(this.btnArchivo_Click);
            // 
            // FrmBitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(923, 442);
            this.Controls.Add(this.btnArchivo);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.CBWPS);
            this.Controls.Add(this.CBPSK);
            this.Controls.Add(this.CBWPA);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtSSID);
            this.Controls.Add(this.CBActivar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmBitacora";
            this.Text = "8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CBActivar;
        private System.Windows.Forms.TextBox txtSSID;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox CBWPA;
        private System.Windows.Forms.CheckBox CBPSK;
        private System.Windows.Forms.CheckBox CBWPS;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnArchivo;
    }
}