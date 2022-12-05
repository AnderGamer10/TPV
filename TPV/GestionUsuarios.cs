using Microsoft.VisualBasic;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            Close();
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
                modTxtNewName.Enabled = true;
                modTxtPasswd.Enabled = true;
                modComboRol.Enabled = true;
            }
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            if (addTxtName.Text.Trim().Length < 1 || addTxtPasswd.Text.Trim().Length < 1 || addComboRol.Text.Trim().Length < 1)
            {
                Microsoft.VisualBasic.Interaction.MsgBox("Rellene todos los campos");
            }
            else if (listUsuarios.Items.Contains(addTxtName.Text))
            {
                Microsoft.VisualBasic.Interaction.MsgBox("Ya existe");
            }
            else
            {
                MySqlConnection myCon = new MySqlConnection(cadenaConexion);
                myCon.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO usuarios (Nombre_Usuario, Password, Rol) VALUES('" + addTxtName.Text.Trim() + "', '" + addTxtPasswd.Text.Trim() + "', '" + addComboRol.Text.Trim() + "');", myCon);
                cmd.ExecuteReader();
                listUsuarios.Items.Add(addTxtName.Text.Trim());
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(modTxtNewName.Text.Trim().Length < 1 || modTxtPasswd.Text.Trim().Length < 1 || modComboRol.Text.Trim().Length < 1)
            {
                Microsoft.VisualBasic.Interaction.MsgBox("Rellene todos los campos");
            }
            else
            {
                MySqlConnection myCon = new MySqlConnection(cadenaConexion);
                myCon.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE Usuarios SET Nombre_Usuario = '" + modTxtNewName.Text.Trim() + "', Password = '" + modTxtPasswd.Text.Trim() + "', Rol = '" + modComboRol.Text.Trim() + "' WHERE Nombre_Usuario = '" + modTxtName.Text.Trim() + "';", myCon);
                cmd.ExecuteReader();
                Microsoft.VisualBasic.Interaction.MsgBox("Los datos han sido actualizados");
            }
            
        }
    }
}
