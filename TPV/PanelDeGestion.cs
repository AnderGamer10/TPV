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
            Close();
            new Login().Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Close();
            new GestionUsuarios(rolVal, cadenaConexion).Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            Close();
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
            if (rolVal.Equals("administrator"))
            {
                btnTickets.Visible = false;
                btnSalir.Width = 295;
                btnSalir.Left = 44;
            }
        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            Close();
            new Tickets(rolVal, cadenaConexion).Show();
        }
    }
}
