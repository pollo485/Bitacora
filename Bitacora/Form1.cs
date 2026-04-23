using System;
using System.Collections;
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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Bitacora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string NombreUsuario { get; set; } = "";
        private string RutaJson = "Usuarios.json";

        private List<Usuarios> CargarUsuarios()
        {
            if (!File.Exists(RutaJson)) return new List<Usuarios>();
            string json = File.ReadAllText(RutaJson);
            return JsonSerializer.Deserialize<List<Usuarios>>(json) ?? new List<Usuarios>();
        }

        private void GuardarUsuarios(List<Usuarios> lista)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            File.WriteAllText(RutaJson, JsonSerializer.Serialize(lista, options));
        }

        private void btnSesion_Click(object sender, EventArgs e)
        {

            string nombre = txtUser.Text.Trim();
            string contrasena = txtPassword.Text;

            var usuarios = CargarUsuarios();
            var usuarioExistente = usuarios.FirstOrDefault(u =>
                u.NombreUsuario.Equals(nombre, StringComparison.OrdinalIgnoreCase));

            if (usuarioExistente != null)
            {
                // Usuario ya existe → validar contraseña
                if (usuarioExistente.ContrasenaUsuario != contrasena)
                {
                    MessageBox.Show("Contraseña incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                // Usuario nuevo → agregar al JSON
                usuarios.Add(new Usuarios
                {
                    NombreUsuario = nombre,
                    ContrasenaUsuario = contrasena,
                    FechaUsuario = DateTime.Now
                });
                GuardarUsuarios(usuarios);
                MessageBox.Show($"Usuario '{nombre}' registrado.", "Nuevo usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Abrir menú/bitácora pasando el usuario
            FrmBitacora forma = new FrmBitacora(nombre, txtPassword.Text);
            forma.Show();
            this.Hide();
        }
    }
}
