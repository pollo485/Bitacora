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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "SSID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // CBActivar
            // 
            this.CBActivar.AutoSize = true;
            this.CBActivar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBActivar.Location = new System.Drawing.Point(598, 49);
            this.CBActivar.Name = "CBActivar";
            this.CBActivar.Size = new System.Drawing.Size(210, 33);
            this.CBActivar.TabIndex = 2;
            this.CBActivar.Text = "Activar 5Ghz";
            this.CBActivar.UseVisualStyleBackColor = true;
            this.CBActivar.CheckedChanged += new System.EventHandler(this.CBActivar_CheckedChanged);
            // 
            // txtSSID
            // 
            this.txtSSID.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSSID.Location = new System.Drawing.Point(93, 10);
            this.txtSSID.Name = "txtSSID";
            this.txtSSID.Size = new System.Drawing.Size(480, 37);
            this.txtSSID.TabIndex = 3;
            this.txtSSID.TextChanged += new System.EventHandler(this.txtSSID_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(167, 84);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(406, 37);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // CBWPA
            // 
            this.CBWPA.AutoSize = true;
            this.CBWPA.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBWPA.Location = new System.Drawing.Point(51, 135);
            this.CBWPA.Name = "CBWPA";
            this.CBWPA.Size = new System.Drawing.Size(103, 33);
            this.CBWPA.TabIndex = 5;
            this.CBWPA.Text = "WPA";
            this.CBWPA.UseVisualStyleBackColor = true;
            this.CBWPA.CheckedChanged += new System.EventHandler(this.CBWPA_CheckedChanged);
            // 
            // CBPSK
            // 
            this.CBPSK.AutoSize = true;
            this.CBPSK.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBPSK.Location = new System.Drawing.Point(244, 135);
            this.CBPSK.Name = "CBPSK";
            this.CBPSK.Size = new System.Drawing.Size(93, 33);
            this.CBPSK.TabIndex = 6;
            this.CBPSK.Text = "PSK";
            this.CBPSK.UseVisualStyleBackColor = true;
            this.CBPSK.CheckedChanged += new System.EventHandler(this.CBPSK_CheckedChanged);
            // 
            // CBWPS
            // 
            this.CBWPS.AutoSize = true;
            this.CBWPS.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBWPS.Location = new System.Drawing.Point(525, 135);
            this.CBWPS.Name = "CBWPS";
            this.CBWPS.Size = new System.Drawing.Size(101, 33);
            this.CBWPS.TabIndex = 7;
            this.CBWPS.Text = "WPS";
            this.CBWPS.UseVisualStyleBackColor = true;
            this.CBWPS.CheckedChanged += new System.EventHandler(this.CBWPS_CheckedChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 174);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1014, 366);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // FrmBitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(1038, 552);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.CBWPS);
            this.Controls.Add(this.CBPSK);
            this.Controls.Add(this.CBWPA);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtSSID);
            this.Controls.Add(this.CBActivar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmBitacora";
            this.Text = "Bitacora";
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
    }
}