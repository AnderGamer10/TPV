using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using iTextSharp.text.pdf;
using iTextSharp.text;
using Document = iTextSharp.text.Document;

namespace TPV
{
    public partial class Tickets : Form
    {
        string rolVal;
        string cadenaConexion;
        public Tickets(string rolVal, string cadenaConexion)
        {
            this.rolVal = rolVal;
            this.cadenaConexion = cadenaConexion;
            InitializeComponent();
        }

        private void Tickets_Load(object sender, EventArgs e)
        {
            MySqlConnection myCon = new MySqlConnection(cadenaConexion);
            myCon.Open();

            MySqlDataAdapter myadapter = new MySqlDataAdapter("SELECT * FROM productos WHERE Stock != 0", myCon);
            DataTable dt = new DataTable();
            myadapter.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                //System.Diagnostics.Debug.WriteLine(dr["Articulo"]);
                listProductos.Items.Add(dr["Articulo"]);
            }
        }

        private void btnCancelarTicket_Click(object sender, EventArgs e)
        {
            Close();
            new PanelDeGestion(rolVal, cadenaConexion).Show();
        }

        private void btnAnyadirProducto_Click(object sender, EventArgs e)
        {
            MySqlConnection myCon = new MySqlConnection(cadenaConexion);
            myCon.Open();

            MySqlDataAdapter myadapter = new MySqlDataAdapter("SELECT * FROM productos WHERE Articulo = '" + listProductos.SelectedItem + "'", myCon);
            DataTable dt = new DataTable();
            myadapter.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                int stock = (int)dr["Stock"];
                int cantidadElegida = 0;
                foreach (var item in listProductosAnyadidos.Items)
                {
                    if (item.ToString().Equals(listProductos.SelectedItem))
                    {
                        cantidadElegida++;
                        
                    }
                }
                System.Diagnostics.Debug.WriteLine(cantidadElegida);
                if (stock > 0 && cantidadElegida < stock)
                {
                    listProductosAnyadidos.Items.Add(listProductos.SelectedItem);
                }
                else
                {
                    Microsoft.VisualBasic.Interaction.MsgBox("No hay existencias");
                }
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        { 
            listProductosAnyadidos.Items.Remove(listProductosAnyadidos.SelectedItem);
        }

        private void btnCrearTicket_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/cuenta.pdf";
            Document document = new Document();
            FileStream fs = File.Create(path);
            PdfWriter.GetInstance(document, fs);
            document.Open();
            /*foreach (var item in listProductosAnyadidos.Items)
            {
                int num = 0;
                
                document.Add(new Paragraph(item + " " + num));
            }*/
            
            //document.Add(new Paragraph("Este es mi primer PDF al vuelo"));

            document.Close();

        }
    }
}
