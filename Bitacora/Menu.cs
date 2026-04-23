using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bitacora
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnArchivo_Click(object sender, EventArgs e)
        {
            Archivo frmArchivo = new Archivo();
            frmArchivo.Show();
        }

        private void btnBitacora_Click(object sender, EventArgs e)
        {
            FrmBitacora frmBitacora = new FrmBitacora("lol","lmao");
            frmBitacora.Show();
        }
    }
}
