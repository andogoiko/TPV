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

                        /*tbUsername.Text = dr["username"].ToString();

                        tbPassword.Text = dr["password"].ToString();

                        if ((bool)dr["admin"] == true)
                        {
                            cbAdmin.Checked = true;
                        }*/

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

                        Usuarios.clearList();
                        Usuarios.feedList();

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
                //UPDATE PRODUCTOS SET articulo = NULL, precio = NULL, stock = NULL, impuestos = NULL, tipo = NULL WHERE codigo = 0;

            }

            this.Close();
        }
    }
}
