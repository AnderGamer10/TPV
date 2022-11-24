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
                string pwd = "admin";
                string cadenaConexion = "server=" + server + ";database=" + database + ";" + "Uid=" + user + ";pwd=" + pwd + ";";
                MySqlConnection myCon = new MySqlConnection(cadenaConexion);
                myCon.Open();

                MySqlDataAdapter sda = new MySqlDataAdapter("SELECT COUNT(*) FROM usuarios WHERE Nombre_Usuario='" + txtUsuario.Text + "' AND Password='" + txtContra.Text + "'", myCon);

                DataTable dt = new DataTable(); 
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    Hide();
                    new tpv().Show();
                }
                else
                    MessageBox.Show("Usuario o contraseña no valida");
                //label1.Text = "Bien";
            }
            catch (Exception error)
            {
                //label1.Text = "Error de conexion " + error;
            }
        }
    }
}