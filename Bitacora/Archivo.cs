using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Bitacora
{
    public partial class Archivo : Form
    {
        private Dictionary<string, List<string>> accionesDeUsuarios = new Dictionary<string, List<string>>();
        private string direccionActual = null;
        private string RutaJson = "Usuarios.json";

        private string _usuario;
        private string _password;

        public Archivo(string usuario, string password)
        {
            InitializeComponent();
            _usuario = usuario;
            _password = password;
        }

        public Archivo()
        {
            InitializeComponent();
        }
        private void log(string accion, string detalles = "")
        {
            string hora = DateTime.Now.ToString("HH:mm:ss");
            string entrada = $"[{hora}] {accion}{(detalles != "" ? " → " + detalles : "")}";

            if (!accionesDeUsuarios.ContainsKey(_usuario))
                accionesDeUsuarios[_usuario] = new List<string>();

            accionesDeUsuarios[_usuario].Add(entrada);
            FiltrarYMostrarArchivo();
            //SetStatus($"{usuarioActual}: {action}");
        }

        private void refrescarLog()
        {
            rtbLogDeAcciones.Clear();
            string filtro = cbUsuarios.SelectedItem?.ToString();
            bool mostrarTodos = filtro == null || filtro.StartsWith("—");

            foreach (var par in accionesDeUsuarios)
            {
                if (!mostrarTodos && par.Key != filtro) continue;

                rtbLogDeAcciones.SelectionStart = rtbLogDeAcciones.TextLength;
                //rtbLogDeAcciones.SelectionColor = Color.FromArgb(255, 220, 100);
                //rtbLogDeAcciones.SelectionFont = new Font("Cascadia Code", 9.5f, FontStyle.Bold);
                rtbLogDeAcciones.AppendText($"\n▶ {par.Key}\n");

                foreach (var line in par.Value)
                {
                    rtbLogDeAcciones.SelectionStart = rtbLogDeAcciones.TextLength;
                    //rtbLogDeAcciones.SelectionFont = new Font("Cascadia Code", 9f);
                    rtbLogDeAcciones.AppendText($"  {line}\n");
                }
            }
            rtbLogDeAcciones.ScrollToCaret();
        }

        private void CargarUsuarios()
        {
            cbUsuarios.Items.Clear();
            cbUsuarios.Items.Add("— Todos —");

            if (System.IO.File.Exists(RutaJson))
            {
                string json = System.IO.File.ReadAllText(RutaJson);
                var lista = JsonSerializer.Deserialize<List<Usuarios>>(json);
                if (lista != null)
                    foreach (var u in lista)
                        cbUsuarios.Items.Add(u.NombreUsuario);
            }

            cbUsuarios.SelectedIndex = 0;
        }

        private void cbUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            //refrescarLog();
            FiltrarYMostrarArchivo();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string direccion = @"C:\Unidad3-Redes\" + txtNombre.Text + ".txt";
            using (FileStream fs = System.IO.File.Create(direccion))
            {
                byte[] info = new UTF8Encoding(true).GetBytes(rtbTxtArchivo.Text);
                fs.Write(info, 0, info.Length);
            }
            log("Guardar", Path.GetFileName(direccion));
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog
            {
                Title = "Abrir archivo de texto",
                Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
            };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                rtbTxtArchivo.Text = System.IO.File.ReadAllText(dlg.FileName);
                log("Leer", Path.GetFileName(dlg.FileName));
            }
        }

        private void Archivo_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
            cbUsuarios.SelectedIndexChanged += cbUsuarios_SelectedIndexChanged;

            string direccion = @"C:\Unidad3-Redes\" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt";
            if (System.IO.File.Exists(direccion))
            {
                rtbTxtArchivo.Text = System.IO.File.ReadAllText(direccion);
                log("Leer", Path.GetFileName(direccion));
            }
        }

        private void btnAppend_Click(object sender, EventArgs e)
        {
            /*string direccion = @"C:\Unidad3-Redes\" + txtNombre.Text + ".txt";

            if (!System.IO.File.Exists(direccion))
            {
                MessageBox.Show("El archivo no existe. Usa Guardar primero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }*/

            btnGuardar_Click(sender, e);
            rtbLogDeAcciones.Text = rtbTxtArchivo.Text;

            /*using (StreamWriter sw = System.IO.File.AppendText(direccion))
            {
                sw.Write(rtbTxtArchivo.Text);
            }*/
        }

        private void FiltrarYMostrarArchivo()
        {
            string fecha = DateTime.Now.ToString("yyyy-MM-dd");
            string direccion = @"C:\Unidad3-Redes\" + fecha + ".txt";

            rtbLogDeAcciones.Clear();

            if (!System.IO.File.Exists(direccion))
            {
                rtbLogDeAcciones.Text = "(No hay archivo de bitácora para hoy)";
                return;
            }

            string filtro = cbUsuarios.SelectedItem?.ToString();
            bool mostrarTodos = filtro == null || filtro.StartsWith("—");

            string[] lineas = System.IO.File.ReadAllLines(direccion);

            int i = 0;
            while (i < lineas.Length)
            {
                string linea = lineas[i];

                if (linea.StartsWith("[") && linea.Contains("]=IN") ||
                    (linea.StartsWith("[") && linea.Contains("GMT-7=IN")))
                {
                    int inicio = linea.IndexOf('[') + 1;
                    int fin = linea.IndexOf(']');
                    string usuarioLinea = (inicio >= 1 && fin > inicio)
                        ? linea.Substring(inicio, fin - inicio)
                        : "";

                    string encabezado = linea;
                    string descripcion = (i + 1 < lineas.Length) ? lineas[i + 1] : "";
                    string vacia = (i + 2 < lineas.Length) ? lineas[i + 2] : "";

                    if (mostrarTodos || usuarioLinea == filtro)
                    {
                        rtbLogDeAcciones.SelectionStart = rtbTxtArchivo.TextLength;
                        rtbLogDeAcciones.AppendText(encabezado + Environment.NewLine);

                        rtbLogDeAcciones.SelectionStart = rtbTxtArchivo.TextLength;
                        rtbLogDeAcciones.AppendText(descripcion + Environment.NewLine);
                        rtbLogDeAcciones.AppendText(Environment.NewLine);
                    }

                    i += 3;
                }
                else
                {
                    i++;
                }
            }
            rtbLogDeAcciones.ScrollToCaret();
        }
    }
}