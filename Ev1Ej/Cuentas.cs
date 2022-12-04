using Microsoft.VisualBasic.ApplicationServices;
using MySqlConnector;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.Diagnostics;

namespace Ev1Ej
{
    public partial class Cuentas : Form
    {

        private bool admin;

        private static string server = "localhost";
        private static string port = "3316";
        private static string database = "tpv";
        private static string user = "root";
        private static string pwd = "root";

        private double aPagar = 0;

        private static string connStr;

        private static ListBox lbProd;

        private static ListBox lbCliCuenta;

        private static List<Producto> lProductos;

        private static List<Producto> lCuenta;

        private StringReader myReader;

        public Cuentas()
        {
            InitializeComponent();
        }

        public Cuentas(bool admin)
        {
            this.admin = admin;
            InitializeComponent();

            lbProd = lbProductos;

            lbCliCuenta = lbCuenta;

            feedList();
            

    }

    public static void feedList()
    {
        connStr = "server=" + server + ";database=" + database + ";Port=" + port + ";Uid=" + user + ";pwd=" + pwd + ";";

        lProductos = new List<Producto>();
        lCuenta = new List<Producto>();
        Producto p;

        using (MySqlConnection conn = new MySqlConnection(connStr))
        {
            conn.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM PRODUCTOS", conn);

            string dataString = "";


            using (MySqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {

                    lbProd.Items.Add(dr["articulo"].ToString());

                    p = new Producto((int)dr["codigo"], dr["articulo"].ToString(), (double)dr["precio"], (int)dr["stock"], (double)dr["impuestos"], dr["tipo"].ToString());

                    lProductos.Add(p);
                }

            }
        }
    }


    public static void clearList()
    {
        lbProd.Items.Clear();
        lProductos.Clear();

        lbCliCuenta.Items.Clear();
        lCuenta.Clear();
     }

    private void goToMenuCamareros(object sender, MouseEventArgs e)
        {
            MenuCamarero menuCamarero = new MenuCamarero(admin);
            this.Hide();
            menuCamarero.ShowDialog();
            this.Close();
        }

        private void addToCuenta(object sender, MouseEventArgs e)
        {

            while (lbProductos.SelectedItems.Count > 0)
            {

                var busqueda = new List<Producto>();

                if (lCuenta.Count() > 0)
                {
                    busqueda = lCuenta.Where(Producto => Producto.articulo == lbProductos.SelectedItems[0].ToString()).ToList();
                }
                

                if (busqueda.Count() > 0)
                {
                    lCuenta.ForEach(Producto => {

                        if(Producto.articulo == lbProductos.SelectedItems[0].ToString())
                        {

                            var prodAlmacen = lProductos.Where(ProductoAlamc => ProductoAlamc.articulo == Producto.articulo).ToList().ElementAt(0);

                            System.Diagnostics.Debug.WriteLine(prodAlmacen.cantidad + "");

                            if (Producto.cantidad < prodAlmacen.cantidad)
                            {
                                int a = lbCuenta.Items.IndexOf(Producto.articulo + " (" + Producto.cantidad + ")");

                                lbCuenta.Items.RemoveAt(a);

                                Producto.cantidad++;

                                lbCuenta.Items.Insert(a, Producto.articulo + " (" + Producto.cantidad + ")");
                            }
                            else
                            {
                                // Initializes the variables to pass to the MessageBox.Show method.
                                string message = "No quedan existencias";
                                string caption = "Error de stock";
                                MessageBoxButtons buttons = MessageBoxButtons.OK;
                                DialogResult result;

                                // Displays the MessageBox.
                                MessageBox.Show(message, caption, buttons);
                            }


                        }
                    });

                }
                else
                {

                    Producto prodSelec = lProductos.Where(Producto => Producto.articulo == lbProductos.SelectedItems[0].ToString()).ElementAt(0);

                    lCuenta.Add(new Producto(prodSelec.codigo, prodSelec.articulo, prodSelec.precio, 1, prodSelec.impuestos, prodSelec.tipo));

                    lbCuenta.Items.Add(lbProductos.SelectedItems[0].ToString() + " (1)");
                }

                totalAPagar();

                lbProductos.SetSelected(0, false);

            }
        }

        private void removeFromCuenta(object sender, MouseEventArgs e)
        {
            while (lbProductos.SelectedItems.Count > 0)
            {

                var busqueda = new List<Producto>();

                //mirar si hay más de 1 en cantidad y hacer 2 cosas distintas depende de ello

                 busqueda = lCuenta.Where(Producto => Producto.articulo == lbProductos.SelectedItems[0].ToString()).ToList();

                if (busqueda.ElementAt(0).cantidad > 1)
                {

                    int a = lbCuenta.Items.IndexOf(busqueda.ElementAt(0).articulo + " (" + busqueda.ElementAt(0).cantidad + ")");

                    lbCuenta.Items.RemoveAt(a);

                    busqueda.ElementAt(0).cantidad--;

                    lbCuenta.Items.Insert(a, busqueda.ElementAt(0).articulo + " (" + busqueda.ElementAt(0).cantidad + ")");

                }
                else
                {
                    lCuenta = lCuenta.Where(cProd => cProd != busqueda.ElementAt(0)).ToList();

                    lbCuenta.Items.Remove(lbCuenta.SelectedItems[0]);
                }

                totalAPagar();


                lbCuenta.SetSelected(0, false);

            }
        }
        

        private void totalAPagar()
        {

            aPagar = 0;

            double masImpuestos;

            lCuenta.ForEach(Prod =>
            {

                masImpuestos = Prod.precio * Prod.impuestos;

                aPagar += (Prod.precio + masImpuestos) * Prod.cantidad;
            });

            lTotal.Text = "Recibo Total: " + aPagar;

        }

        private void payNImpress(object sender, MouseEventArgs e)
        {

            List<Producto> lActualizar = new List<Producto>();

            for(int i = 0; i < lProductos.Count; i++)
            {
                
                for (int j = 0; j < lCuenta.Count; j++)
                {
                    if(lProductos[i].articulo == lCuenta[j].articulo)
                    {
                        var prodAux = lProductos[i];
                        prodAux.cantidad = prodAux.cantidad - lCuenta[i].cantidad;

                        lActualizar.Add(prodAux);
                    }
                }
            }

            connStr = "server=" + server + ";database=" + database + ";Port=" + port + ";Uid=" + user + ";pwd=" + pwd + ";";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                lActualizar.ForEach(prod =>
                {
                    MySqlCommand cmd = new MySqlCommand("UPDATE PRODUCTOS SET stock = " + prod.cantidad + " WHERE codigo = " + prod.codigo + ";", conn);


                     cmd.ExecuteReader();

                });

            }
            print();

            clearList();
            feedList();

         }

        private void print()
        {

            string cuentaPDF = "";

            lCuenta.ForEach(prodCuenta =>
            {
                cuentaPDF += prodCuenta.articulo + "\t" + prodCuenta.precio + "\t" + "X(" + prodCuenta.cantidad + ")\n";
            });

            cuentaPDF += "Total: " + aPagar.ToString();


            // Create a new PDF document

            PdfDocument document = new PdfDocument();

            document.Info.Title = "Cuenta";

            // Create an empty page

            PdfPage page = document.AddPage();

            // Get an XGraphics object for drawing

            XGraphics gfx = XGraphics.FromPdfPage(page);

            // Create a font

            XFont font = new XFont("Verdana", 20, XFontStyle.BoldItalic);

            // Draw the text

            gfx.DrawString(cuentaPDF, font, XBrushes.Black,
                new XRect(0, 0, page.Width, page.Height),
                XStringFormats.Center);

            // Save the document...

            const string filename = "Cuenta.pdf";

            document.Save(filename);

            // ...and start a viewer.

            Process.Start(filename);

        }


    }
}
