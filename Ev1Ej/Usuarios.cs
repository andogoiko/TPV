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
    public partial class Usuarios : Form
    {

        private bool admin;

        private static string server = "localhost";
        private static string port = "3316";
        private static string database = "tpv";
        private static string user = "root";
        private static string pwd = "root";

        private static string connStr;

        private static ListBox lb;

        public Usuarios()
        {
            InitializeComponent();
        }

        public Usuarios(bool admin)
        {
            InitializeComponent();

            this.admin = admin;

            lb = lbUsuarios;

            feedList();


        }

        public static void feedList()
        {
            connStr = "server=" + server + ";database=" + database + ";Port=" + port + ";Uid=" + user + ";pwd=" + pwd + ";";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM USERS", conn);

                string dataString = "";


                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {

                        lb.Items.Add(dr["username"].ToString());

                    }

                }
            }
        }

        public static void clearList()
        {
            lb.Items.Clear();
        }

        private void goToMenu(object sender, MouseEventArgs e)
        {
            MenuAdmin menu = new MenuAdmin(admin);
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }

        private void checkSelection(object sender, MouseEventArgs e)
        {
            if (lbUsuarios.SelectedItems.Count == 0)
            {
                modificarUsuario.Enabled = false;
                eliminarUsuario.Enabled = false;
            }
            else
            {
                modificarUsuario.Enabled = true;
                eliminarUsuario.Enabled = true;
            }
        }

        private void deleteUsers(object sender, MouseEventArgs e)
        {
            while (lbUsuarios.SelectedItems.Count > 0)
            {

                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("DELETE FROM USERS WHERE username='" + lbUsuarios.SelectedItems[0] + "';", conn);

                    string dataString = "";

                    using (MySqlDataReader dr = cmd.ExecuteReader()){}
                }

                lbUsuarios.Items.Remove(lbUsuarios.SelectedItems[0]);
            }
        }

        private void openUserForm(object sender, MouseEventArgs e)
        {
            if((sender as Button).Name == "anyadirUsuario")
            {
                FormUsuario addUser = new FormUsuario(true);
                addUser.ShowDialog();

            }
            else
            {

                if(lbUsuarios.SelectedItems.Count > 1)
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
                    FormUsuario modifyUser = new FormUsuario(false, lbUsuarios.SelectedItems[0].ToString());
                    modifyUser.ShowDialog();
                }

            }
        }
    }
}
