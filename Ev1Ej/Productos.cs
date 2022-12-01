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
using System.Xml.Linq;

namespace Ev1Ej
{
    public partial class Productos : Form
    {

        private bool admin;

        private static string server = "localhost";
        private static string port = "3316";
        private static string database = "tpv";
        private static string user = "root";
        private static string pwd = "root";

        private static string connStr;

        private static ListBox lb;

        private static List<Producto> lProductos;

        public Productos()
        {
            InitializeComponent();
        }

        public Productos(bool admin)
        {
            InitializeComponent();

            this.admin = admin;

            lb = lbProductos;

            feedList();

        }

        private void goToMenuAdmin(object sender, MouseEventArgs e)
        {
            MenuAdmin menuAdmin = new MenuAdmin(admin);
            this.Hide();
            menuAdmin.ShowDialog();
            this.Close();
        }

        private void goToMenuCamarero(object sender, MouseEventArgs e)
        {
            MenuCamarero menuCamarero = new MenuCamarero(admin);
            this.Hide();
            menuCamarero.ShowDialog();
            this.Close();
        }

        private void goBack(object sender, MouseEventArgs e)
        {
            if (this.admin)
            {
                goToMenuAdmin(sender, e);
            }
            else
            {
                goToMenuCamarero(sender, e);
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

                        lb.Items.Add(dr["articulo"].ToString());

                        p = new Producto((int)dr["codigo"], dr["articulo"].ToString());

                        lProductos.Add(p);

                    }

                }
            }
        }


        public static void clearList()
        {
            lb.Items.Clear();
            lProductos.Clear();
        }

        private void checkSelection(object sender, MouseEventArgs e)
        {
            if (lbProductos.SelectedItems.Count == 0)
            {
                modificarProducto.Enabled = false;
                eliminarProducto.Enabled = false;
            }
            else
            {
                modificarProducto.Enabled = true;
                eliminarProducto.Enabled = true;
            }
        }

        private void deleteProduct(object sender, MouseEventArgs e)
        {

            int codigo;

            while (lbProductos.SelectedItems.Count > 0)
            {

                codigo = lProductos.Where(p => p.articulo == lbProductos.SelectedItems[0].ToString()).ToList().First().codigo;

                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("DELETE FROM PRODUCTOS WHERE codigo='" + codigo + "';", conn);

                    string dataString = "";

                    using (MySqlDataReader dr = cmd.ExecuteReader()) { }
                }

                lProductos = lProductos.Where(p => p.codigo != codigo).ToList();

                lbProductos.Items.Remove(lbProductos.SelectedItems[0]);
            }
        }

        private void openProductForm(object sender, MouseEventArgs e)
        {
            if ((sender as Button).Name == "anyadirProducto")
            {
                FormProducto addProduct = new FormProducto(true);
                addProduct.ShowDialog();

            }
            else
            {

                if (lbProductos.SelectedItems.Count > 1)
                {
                    // Initializes the variables to pass to the MessageBox.Show method.
                    string message = "Selecciona únicamente 1 usuario";
                    string caption = "Error, selección múltiple";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;

                    // Displays the MessageBox.
                    MessageBox.Show(message, caption, buttons);
                }
                else
                {
                    int codigo;

                    codigo = lProductos.Where(p => p.articulo == lbProductos.SelectedItems[0].ToString()).ToList().First().codigo;

                    FormProducto modifyProduct = new FormProducto(false, codigo);
                    modifyProduct.ShowDialog();
                }

            }
        }

    }
}
