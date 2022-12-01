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
    public partial class GestionProductos : Form
    {
        string rolVal;
        string cadenaConexion;

        public GestionProductos(string rolVal, string cadenaConexion)
        {
            this.rolVal = rolVal;
            this.cadenaConexion = cadenaConexion;
            InitializeComponent();
        }

        private void GestionProductos_Load(object sender, EventArgs e)
        {
            MySqlConnection myCon = new MySqlConnection(cadenaConexion);
            myCon.Open();

            MySqlDataAdapter myadapter = new MySqlDataAdapter("SELECT * FROM productos", myCon);
            DataTable dt = new DataTable();
            myadapter.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                //System.Diagnostics.Debug.WriteLine(dr["Articulo"]);
                listProductos.Items.Add(dr["Articulo"]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
