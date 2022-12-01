using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPV
{
    public partial class PanelDeGestion : Form
    {
        string rolVal;
        string cadenaConexion;
        public PanelDeGestion(string rolVal, string cadenaConexion)
        {
            this.rolVal = rolVal;
            this.cadenaConexion = cadenaConexion;
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Hide();
            new GestionUsuarios(rolVal, cadenaConexion).Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            Hide();
            new GestionProductos(rolVal, cadenaConexion).Show();
        }

        private void PanelDeGestion_Load(object sender, EventArgs e)
        {
            if (rolVal.Equals("user"))
            {
                btnUsuarios.Visible = false;
                btnProductos.Width = 295;
                btnProductos.Left = 44;
            }
        }
    }
}
