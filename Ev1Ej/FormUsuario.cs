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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Ev1Ej
{
    public partial class FormUsuario : Form
    {

        private bool add;

        private string server = "localhost";
        private string port = "3316";
        private string database = "tpv";
        private string user = "root";
        private string pwd = "root";

        private string connStr;

        private string userFromList;

        public FormUsuario()
        {
            InitializeComponent();
        }

        public FormUsuario(bool add)
        {
            InitializeComponent();

            this.add = add;

            connStr = "server=" + server + ";database=" + database + ";Port=" + port + ";Uid=" + user + ";pwd=" + pwd + ";";
        }

        public FormUsuario(bool add, string userFromList)
        {
            InitializeComponent();

            this.add = add;
            this.userFromList = userFromList;

            connStr = "server=" + server + ";database=" + database + ";Port=" + port + ";Uid=" + user + ";pwd=" + pwd + ";";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {

                conn.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM USERS WHERE username='" + userFromList + "';", conn);

                using (MySqlDataReader dr = cmd.ExecuteReader())
                {


                    while (dr.Read())
                    {

                        tbUsername.Text = dr["username"].ToString();

                        tbPassword.Text = dr["password"].ToString();

                        if ((bool)dr["admin"] == true)
                        {
                            cbAdmin.Checked = true;
                        }

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

                    int isAdmin;

                    if (cbAdmin.Checked)
                    {
                        isAdmin = 1;
                    }
                    else
                    {
                        isAdmin = 0;
                    }

                    MySqlCommand cmd = new MySqlCommand("INSERT INTO USERS (username, password, admin) VALUES('" + tbUsername.Text + "', '" + tbPassword.Text + "', " + isAdmin + ");", conn);

                    try
                    {
                        cmd.ExecuteReader();

                        Usuarios.clearList();
                        Usuarios.feedList();

                        this.Close();
                    }
                    catch(MySqlException)
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

                    int isAdmin;

                    if (cbAdmin.Checked)
                    {
                        isAdmin = 1;
                    }
                    else
                    {
                        isAdmin = 0;
                    }

                    MySqlCommand cmd = new MySqlCommand("UPDATE USERS SET username='" + tbUsername.Text + "', password='" + tbPassword.Text + "', admin= " + isAdmin + " WHERE username='" + userFromList + "';", conn);

                    System.Diagnostics.Debug.WriteLine("UPDATE USERS SET username='" + tbUsername.Text + "', password='" + tbPassword.Text + "', admin= " + isAdmin + " WHERE username='" + userFromList + "';");

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
                        string message = "El nombre de usuario ya está escogido";
                        string caption = "Error al modificar";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;

                        // Displays the MessageBox.
                        MessageBox.Show(message, caption, buttons);

                    }
                }

            }


        }
    }
}
