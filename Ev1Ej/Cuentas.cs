using Microsoft.VisualBasic.ApplicationServices;
using MySqlConnector;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private int aPagar = 0;

        private static string connStr;

        private static ListBox lbProd;

        private static ListBox lbCliCuenta;

        private static List<Producto> lProductos;

        private static List<Producto> lCuenta = new List<Producto>();

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


                lbCuenta.SetSelected(0, false);

            }
        }
        

        private void totalAPagar()
        {
            //recorrer el array de cuenta hacer el calculo y llamar a esta función cada vez k se añada o quite algo
        }

        private void payNImpress(object sender, MouseEventArgs e)
        {
            //recorrer la completa y mirar cual esta en cuenta, creas nueva lista y copias todo menos stock, debes restar lo de cuanta a productos y llamas a un update

            //  hay k coger los k esten en ambas listas y actualizar bbdd mediante el de la lista de productos, pues ahí está reflejado en vivo el stock
            // se hace cuenta de pagar mediante la lista de cuenta y imprimir no se como va la vd
        }

        private void print()
        {

        }


    }
}
