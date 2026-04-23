namespace Bitacora
{
    partial class Menu
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
            this.btnBitacora = new System.Windows.Forms.Button();
            this.btnArchivo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBitacora
            // 
            this.btnBitacora.Location = new System.Drawing.Point(101, 98);
            this.btnBitacora.Name = "btnBitacora";
            this.btnBitacora.Size = new System.Drawing.Size(75, 23);
            this.btnBitacora.TabIndex = 0;
            this.btnBitacora.Text = "button1";
            this.btnBitacora.UseVisualStyleBackColor = true;
            this.btnBitacora.Click += new System.EventHandler(this.btnBitacora_Click);
            // 
            // btnArchivo
            // 
            this.btnArchivo.Location = new System.Drawing.Point(101, 182);
            this.btnArchivo.Name = "btnArchivo";
            this.btnArchivo.Size = new System.Drawing.Size(75, 23);
            this.btnArchivo.TabIndex = 1;
            this.btnArchivo.Text = "Archivo";
            this.btnArchivo.UseVisualStyleBackColor = true;
            this.btnArchivo.Click += new System.EventHandler(this.btnArchivo_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnArchivo);
            this.Controls.Add(this.btnBitacora);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBitacora;
        private System.Windows.Forms.Button btnArchivo;
    }
}