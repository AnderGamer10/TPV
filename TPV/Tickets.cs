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
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace TPV
{
    public partial class Tickets : Form
    {
        private string rolVal;
        private string cadenaConexion;
        private List<Producto> listaProductos = new List<Producto>();
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
                if (stock > 0 && cantidadElegida < stock)
                {
                    listProductosAnyadidos.Items.Add(listProductos.SelectedItem);
                    if (cantidadElegida == 0)
                    {
                        double precio = (double)dr["Precio"] + ((double)dr["Precio"] * (double)dr["Impuesto"]);
                        listaProductos.Add(new Producto(listProductos.SelectedItem.ToString(), cantidadElegida+1, precio));
                    }
                    else
                    {
                        var obj = listaProductos.FirstOrDefault(x => x.Nombre == listProductos.SelectedItem.ToString());
                        if (obj != null) obj.Cantidad = cantidadElegida + 1;
                    }
                }
                else
                {
                    Microsoft.VisualBasic.Interaction.MsgBox("No hay mas existencias");
                } 
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (listProductosAnyadidos.SelectedItem != null)
            {
                listProductosAnyadidos.Items.Remove(listProductosAnyadidos.SelectedItem);
            }
            else
            {
                Microsoft.VisualBasic.Interaction.MsgBox("Seleccione un elemento a eliminar");
            }
        }

        private void btnCrearTicket_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/cuenta.pdf";
            Document document = new Document();
            FileStream fs = File.Create(path);
            PdfWriter.GetInstance(document, fs);
            document.Open();
            double cantidadTotal = 0;
            foreach (Producto p in listaProductos)
            {
                document.Add(new Paragraph("Nombre: " + p.Nombre + "   Cantidad: " + p.Cantidad + "   Precio+IVA: " + Math.Round(p.Precio, 2) + "€"));
                cantidadTotal += p.Precio * p.Cantidad;

                MySqlConnection myCon = new MySqlConnection(cadenaConexion);
                myCon.Open();
                MySqlDataAdapter myadapter = new MySqlDataAdapter("SELECT * FROM productos WHERE Articulo = '" + listProductos.SelectedItem + "'", myCon);
                DataTable dt = new DataTable();
                myadapter.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    int stock = (int)dr["Stock"];
                    MySqlCommand sda = new MySqlCommand("UPDATE productos SET Stock = '" + (stock-p.Cantidad) + "' WHERE Articulo = '" + p.Nombre + "'; ", myCon);
                    sda.ExecuteReader();
                    myCon.Close();
                }      
            }
            document.Add(new Paragraph("Total a pagar: " + cantidadTotal + "€"));
            document.Close();
            Microsoft.VisualBasic.Interaction.MsgBox("Cuenta creada");
            Close();
            new PanelDeGestion(rolVal, cadenaConexion).Show();
        }
    }  
}
