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
    public partial class FormProducto : Form
    {

        private bool add;

        private string server = "localhost";
        private string port = "3316";
        private string database = "tpv";
        private string user = "root";
        private string pwd = "root";

        private string connStr;

        private int productFromList;

        public FormProducto()
        {
            InitializeComponent();
        }

        public FormProducto(bool add)
        {
            this.add = add;
            InitializeComponent();

            connStr = "server=" + server + ";database=" + database + ";Port=" + port + ";Uid=" + user + ";pwd=" + pwd + ";";
        }

        public FormProducto(bool add, int productFromList)
        {
            InitializeComponent();
            this.add = add;
            this.productFromList = productFromList;

            connStr = "server=" + server + ";database=" + database + ";Port=" + port + ";Uid=" + user + ";pwd=" + pwd + ";";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {

                conn.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM PRODUCTOS WHERE codigo='" + productFromList + "';", conn);

                using (MySqlDataReader dr = cmd.ExecuteReader())
                {


                    while (dr.Read())
                    {

                        tbArticulo.Text = dr["articulo"].ToString();

                        tbPrecio.Text = dr["precio"].ToString();

                        tbStock.Text = dr["stock"].ToString();

                        tbImpuestos.Text = dr["impuestos"].ToString();

                        tbTipo.Text = dr["tipo"].ToString();


                    }

                }

            }

        }

        private void doQuery(object sender, MouseEventArgs e)
        {
            if (add)
            {

                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

 
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO PRODUCTOS (articulo, precio, stock, impuestos, tipo) VALUES('" + tbArticulo.Text + "', " + tbPrecio.Text + ", " + tbStock.Text + ", " + tbImpuestos.Text + ", '" + tbTipo.Text + "');", conn);

                    try
                    {
                        cmd.ExecuteReader();

                        Productos.clearList();
                        Productos.feedList();

                        this.Close();
                    }
                    catch (MySqlException)
                    {
                        // Initializes the variables to pass to the MessageBox.Show method.
                        string message = "La entrada que se quiere crear ya existe";
                        string caption = "Error al crear";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;

                        // Displays the MessageBox.
                        MessageBox.Show(message, caption, buttons);

                    }
                }

            }
            else
            {

                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("UPDATE PRODUCTOS SET articulo = '" + tbArticulo.Text + "', precio = " + tbPrecio.Text + ", stock = " + tbStock.Text + ", impuestos = " + tbImpuestos.Text + ", tipo = '" + tbTipo.Text + "' WHERE codigo = " + productFromList + ";", conn);

                    try
                    {
                        cmd.ExecuteReader();

                        Productos.clearList();
                        Productos.feedList();

                        this.Close();
                    }
                    catch (MySqlException)
                    {
                        // Initializes the variables to pass to the MessageBox.Show method.
                        string message = "El producto tiene algún dato incorrecto";
                        string caption = "Error al modificar";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;

                        // Displays the MessageBox.
                        MessageBox.Show(message, caption, buttons);

                    }

                }

             }

            this.Close();
        }

        private void checkDoubleNumber(object sender, KeyEventArgs e)
        {

        }

        private void checkIntNumber(object sender, KeyEventArgs e)
        {

        }
    }
}
