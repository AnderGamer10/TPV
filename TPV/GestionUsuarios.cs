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
    public partial class GestionUsuarios : Form
    {
        string rolVal;
        string cadenaConexion;
        public GestionUsuarios(string rolVal, string cadenaConexion)
        {
            this.rolVal = rolVal;
            this.cadenaConexion = cadenaConexion;
            InitializeComponent();
        }

        private void groupUsuarios_Enter(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            new PanelDeGestion(rolVal, cadenaConexion).Show();
        }

        private void GestionUsuarios_Load(object sender, EventArgs e)
        {
            addComboRol.DropDownStyle = ComboBoxStyle.DropDownList;
            modComboRol.DropDownStyle = ComboBoxStyle.DropDownList;
            MySqlConnection myCon = new MySqlConnection(cadenaConexion);
            myCon.Open();

            MySqlDataAdapter myadapter = new MySqlDataAdapter("SELECT * FROM usuarios", myCon);
            DataTable dt = new DataTable();
            myadapter.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                listUsuarios.Items.Add(dr["Nombre_Usuario"]);
            }   
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            if (delTxtName.Text == null)
            {
                Microsoft.VisualBasic.Interaction.MsgBox(
                                    "Seleccione o intrduzca un usuario para eliminarlo");
            }
            else
            {
                if(listUsuarios.SelectedItem == null || listUsuarios.SelectedItem.ToString() != delTxtName.Text)
                {
                    listUsuarios.Items.Remove(delTxtName.Text);
                    eliminarUsuario(delTxtName.Text);
                }
                else
                {
                    for (int x = listUsuarios.SelectedIndices.Count - 1; x >= 0; x--)
                    {
                        int var = listUsuarios.SelectedIndices[x];
                        listUsuarios.Items.RemoveAt(var);
                        eliminarUsuario(delTxtName.Text);
                    }

                    if (listUsuarios.Items.Count == 0)
                    {
                        listUsuarios.Text = "";
                    }
                }
                
            }


        }

        private void eliminarUsuario(string nombreUsuario)
        {
            MySqlConnection myCon = new MySqlConnection(cadenaConexion);
            myCon.Open();

            MySqlCommand cmd = new MySqlCommand("DELETE FROM Usuarios WHERE Nombre_Usuario= '" + nombreUsuario + "'", myCon);
            cmd.ExecuteReader();
        }
        private void anyadirUsuario()
        {
            MySqlConnection myCon = new MySqlConnection(cadenaConexion);
            myCon.Open();

            MySqlCommand cmd = new MySqlCommand("INSERT INTO usuarios (Nombre_Usuario, Password, Rol) VALUES('" + addTxtName.Text + "', '" + addTxtPasswd.Text + "', '" + addComboRol.Text + "');", myCon);
            cmd.ExecuteReader();
            listUsuarios.Items.Add(addTxtName.Text);
        }
        private void listUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (addTxtName.Text != null || addTxtName.Text != "")
            {
                addTxtName.Text = "";
            }

            foreach (object item in listUsuarios.SelectedItems)
            {
                modTxtName.Text = item.ToString();
                delTxtName.Text = item.ToString();
            }
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            anyadirUsuario();
        }
    }
}
