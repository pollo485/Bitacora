namespace Bitacora
{
    partial class Archivo
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
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAppend = new System.Windows.Forms.Button();
            this.rtbTxtArchivo = new System.Windows.Forms.RichTextBox();
            this.rtbLogDeAcciones = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxFecha = new System.Windows.Forms.TextBox();
            this.txtBoxHora = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(61, 13);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(100, 31);
            this.btnLeer.TabIndex = 0;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(206, 13);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 31);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAppend
            // 
            this.btnAppend.Location = new System.Drawing.Point(350, 12);
            this.btnAppend.Name = "btnAppend";
            this.btnAppend.Size = new System.Drawing.Size(100, 31);
            this.btnAppend.TabIndex = 2;
            this.btnAppend.Text = "Append";
            this.btnAppend.UseVisualStyleBackColor = true;
            // 
            // rtbTxtArchivo
            // 
            this.rtbTxtArchivo.Location = new System.Drawing.Point(6, 92);
            this.rtbTxtArchivo.Name = "rtbTxtArchivo";
            this.rtbTxtArchivo.Size = new System.Drawing.Size(434, 330);
            this.rtbTxtArchivo.TabIndex = 3;
            this.rtbTxtArchivo.Text = "";
            // 
            // rtbLogDeAcciones
            // 
            this.rtbLogDeAcciones.Location = new System.Drawing.Point(446, 92);
            this.rtbLogDeAcciones.Name = "rtbLogDeAcciones";
            this.rtbLogDeAcciones.Size = new System.Drawing.Size(434, 330);
            this.rtbLogDeAcciones.TabIndex = 4;
            this.rtbLogDeAcciones.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(446, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Acciones de";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(534, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(880, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(883, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hora";
            // 
            // txtBoxFecha
            // 
            this.txtBoxFecha.Location = new System.Drawing.Point(932, 22);
            this.txtBoxFecha.Name = "txtBoxFecha";
            this.txtBoxFecha.Size = new System.Drawing.Size(196, 22);
            this.txtBoxFecha.TabIndex = 9;
            // 
            // txtBoxHora
            // 
            this.txtBoxHora.Location = new System.Drawing.Point(932, 68);
            this.txtBoxHora.Name = "txtBoxHora";
            this.txtBoxHora.Size = new System.Drawing.Size(196, 22);
            this.txtBoxHora.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(68, 56);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(196, 22);
            this.txtNombre.TabIndex = 12;
            // 
            // Archivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 523);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxHora);
            this.Controls.Add(this.txtBoxFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbLogDeAcciones);
            this.Controls.Add(this.rtbTxtArchivo);
            this.Controls.Add(this.btnAppend);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLeer);
            this.Name = "Archivo";
            this.Text = "Archivo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAppend;
        private System.Windows.Forms.RichTextBox rtbTxtArchivo;
        private System.Windows.Forms.RichTextBox rtbLogDeAcciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxFecha;
        private System.Windows.Forms.TextBox txtBoxHora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
    }
}