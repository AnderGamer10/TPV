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
            addComboType.DropDownStyle = ComboBoxStyle.DropDownList;
            modComboType.DropDownStyle = ComboBoxStyle.DropDownList;
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (delTxtName.Text == null)
            {
                Microsoft.VisualBasic.Interaction.MsgBox(
                                    "Seleccione o intrduzca un usuario para eliminarlo");
            }
            else
            {
                if (listProductos.SelectedItem == null || listProductos.SelectedItem.ToString() != delTxtName.Text)
                {
                    listProductos.Items.Remove(delTxtName.Text);
                    eliminarProducto(delTxtName.Text);
                }
                else
                {
                    for (int x = listProductos.SelectedIndices.Count - 1; x >= 0; x--)
                    {
                        int var = listProductos.SelectedIndices[x];
                        listProductos.Items.RemoveAt(var);
                        eliminarProducto(delTxtName.Text);
                    }

                    if (listProductos.Items.Count == 0)
                    {
                        listProductos.Text = "";
                    }
                }
            }
        }
        private void eliminarProducto(string nombreProducto)
        {
            MySqlConnection myCon = new MySqlConnection(cadenaConexion);
            myCon.Open();

            MySqlCommand cmd = new MySqlCommand("DELETE FROM productos WHERE Articulo = '" + nombreProducto + "'", myCon);
            cmd.ExecuteReader();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
            new PanelDeGestion(rolVal, cadenaConexion).Show();
        }

        private void listProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (addTxtName.Text != null || addTxtName.Text != "")
            {
                addTxtName.Text = "";
            }

            foreach (object item in listProductos.SelectedItems)
            {
                modTxtName.Text = item.ToString();
                delTxtName.Text = item.ToString();
                modTxtNewName.Enabled = true;
                modTxtPrice.Enabled = true;
                modTxtStock.Enabled = true;
                modTxtImpuesto.Enabled = true;
                modComboType.Enabled = true;
            }
        }



        private void btnAnyadir_Click(object sender, EventArgs e)
        {
            if (addTxtName.Text.Trim().Length < 1 || addTxtPrice.Text.Trim().Length < 1 || addTxtStock.Text.Trim().Length < 1 || addTxtImpuesto.Text.Trim().Length < 1 || addComboType.Text.Trim().Length < 1)
            {
                Microsoft.VisualBasic.Interaction.MsgBox("Rellene todos los campos");
            }
            else if (listProductos.Items.Contains(addTxtName.Text))
            {
                Microsoft.VisualBasic.Interaction.MsgBox("Ya existe");
            }
            else
            {
                MySqlConnection myCon = new MySqlConnection(cadenaConexion);
                myCon.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO productos (Articulo, Precio, Stock, Impuesto, Tipo) VALUES('" + addTxtName.Text.Trim() + "', '" + addTxtPrice.Text.Trim() + "', '" + addTxtStock.Text.Trim() + "', '" + addTxtImpuesto.Text.Trim() + "', '" + addComboType.Text.Trim() + "');", myCon);
                cmd.ExecuteReader();
                listProductos.Items.Add(addTxtName.Text.Trim());
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (modTxtNewName.Text.Trim().Length < 1 || modTxtPrice.Text.Trim().Length < 1 || modTxtStock.Text.Trim().Length < 1 || modTxtImpuesto.Text.Trim().Length < 1 || modComboType.Text.Trim().Length < 1)
            {
                Microsoft.VisualBasic.Interaction.MsgBox("Rellene todos los campos");
            }
            else
            {
                MySqlConnection myCon = new MySqlConnection(cadenaConexion);
                myCon.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE productos SET Articulo = '" + modTxtNewName.Text.Trim() + "', Precio = '" + modTxtPrice.Text.Trim() + "', Stock = '" + modTxtStock.Text.Trim() + "', Impuesto = '" + modTxtImpuesto.Text.Trim() + "', Tipo = '" + modComboType.Text.Trim() + "' WHERE Articulo = '" + modTxtName.Text.Trim() + "';", myCon);
                cmd.ExecuteReader();
                Microsoft.VisualBasic.Interaction.MsgBox("Los datos han sido actualizados");
            }
        }
    }
}
