using Microsoft.VisualBasic.ApplicationServices;
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

        private static string connStr;

        private static ListBox lbProd;

        private static ListBox lbCliCuenta;

        private static List<Producto> lProductos;

        private static List<Producto> lCuenta;

        public Cuentas()
        {
            InitializeComponent();
        }

        public Cuentas(bool admin)
        {
            this.admin = admin;
            InitializeComponent();

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {

                conn.Open();

                lbProd = lbProductos;

                lbCliCuenta = lbCuenta;

                feedList();
            }

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

                    p = new Producto((int)dr["codigo"], dr["articulo"].ToString(), (double)dr["precio"], (int)dr["cantidad"], (double)dr["impuestos"], dr["tipo"].ToString());

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
            //al añadir mirar si esta el k tenga ese code en el array, si esta añadir 1 mas en cantidad (lo k aparecerá en el lb sera articulo name + cant)
            //ala añadir tmb mirar el stock real y si keda en 0 invalidar ese elemento de la lb
        }

        private void removeFromCuenta(object sender, MouseEventArgs e)
        {

        }

        private void payNImpress(object sender, MouseEventArgs e)
        {
            //  hay k coger los k esten en ambas listas y actualizar bbdd mediante el de la lista de productos, pues ahí está reflejado en vivo el stock
            // se hace cuenta de pagar mediante la lista de cuenta y imprimir no se como va la vd
        }
    }
}
