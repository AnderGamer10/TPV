using MySqlConnector;
using System.Drawing;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TPV
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string server = "localhost";
                string database = "tpv";
                string user = "root";
                string pwd = "admin"; //admin en clase / root en casa
                string cadenaConexion = "server=" + server + ";database=" + database + ";" + "Uid=" + user + ";pwd=" + pwd + ";";
                MySqlConnection myCon = new MySqlConnection(cadenaConexion);
                myCon.Open();

                MySqlDataAdapter myadapter = new MySqlDataAdapter("SELECT COUNT(*) FROM usuarios WHERE Nombre_Usuario='" + txtUsuario.Text + "' AND Password='" + txtContra.Text + "'", myCon);


                DataTable dt = new DataTable();
                myadapter.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MySqlDataAdapter myadapter2 = new MySqlDataAdapter("SELECT * FROM usuarios WHERE Nombre_Usuario='" + txtUsuario.Text + "' AND Password='" + txtContra.Text + "'", myCon);
                    DataTable dt2 = new DataTable();
                    myadapter2.Fill(dt2);
                    string rolVal = dt2.Rows[0][3].ToString();
                    Hide();
                    new PanelDeGestion(rolVal, cadenaConexion).Show();
                }
                else
                    MessageBox.Show("Usuario o contraseña no valida");
            }
            catch (Exception error)
            {
                //label1.Text = "Error de conexion " + error;
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}