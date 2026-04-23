using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Bitacora
{
    public partial class FrmBitacora : Form
    {
        private string _usuario;
        private string _password;

        public FrmBitacora(string usuario, string password)
        {
            InitializeComponent();
            _usuario = usuario;
            _password = password;
        }

        private void RegistrarCambio(string descripcion)
        {
            string fecha = DateTime.Now.ToString("yyyy-MM-dd");
            string hora = DateTime.Now.ToString("HH:mm");
            string encabezado = $"[{_usuario}]:[{_password}]:{fecha};{hora}GMT-7=IN";

            //if (!File.Exists(@"C:\Unidad3-Redes\" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt")) System.IO.File.Create(@"C:\Unidad3-Redes\" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt");

            richTextBox1.AppendText(encabezado + Environment.NewLine);
            richTextBox1.AppendText(descripcion + Environment.NewLine);
            richTextBox1.AppendText(Environment.NewLine);
            string direccion = @"C:\Unidad3-Redes\" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt";
            using (FileStream fs = System.IO.File.OpenWrite(direccion))
            {
                AddText(fs, richTextBox1.Text);
            }
            richTextBox1.ScrollToCaret();
        }

        private static void AddText(FileStream fs, string value)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(value);
            fs.Write(info, 0, info.Length);
        }

        private void txtSSID_TextChanged(object sender, EventArgs e)
        {
            RegistrarCambio($"Ha cambiado el SSID a: \"{txtSSID.Text}\"");
        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            RegistrarCambio($"Ha modificado el Password (longitud: {txtPassword.Text.Length} caracteres)");
        }

        private void CBActivar_CheckedChanged(object sender, EventArgs e)
        {
            string accion = CBActivar.Checked ? "activado" : "desactivado";
            RegistrarCambio($"Ha {accion} la banda de 5GHz");
        }

        private void CBWPA_CheckedChanged(object sender, EventArgs e)
        {
            string accion = CBWPA.Checked ? "activado" : "desactivado";
            RegistrarCambio($"Ha {accion} WPA");
        }

        private void CBPSK_CheckedChanged(object sender, EventArgs e)
        {
            string accion = CBPSK.Checked ? "activado" : "desactivado";
            RegistrarCambio($"Ha {accion} PSK");
        }

        private void CBWPS_CheckedChanged(object sender, EventArgs e)
        {
            string accion = CBWPS.Checked ? "activado" : "desactivado";
            RegistrarCambio($"Ha {accion} WPS");
        }

        private void btnArchivo_Click(object sender, EventArgs e)
        {
           Archivo forma = new Archivo(_usuario, _password);
           forma.Show();
        }
    }
}