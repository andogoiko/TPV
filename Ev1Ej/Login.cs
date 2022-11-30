using MySqlConnector;
using System.Collections;
using System;
using System.Data;
using System.Data.Common;

namespace Ev1Ej
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void login(object sender, MouseEventArgs e)
        {
            string server = "localhost";
            string port = "3316";
            string database = "tpv";
            string user = "root";
            string pwd = "root";

            string connStr = "server=" + server + ";database=" + database + ";Port=" + port + ";Uid=" + user + ";pwd=" + pwd + ";";

            //MySqlDataAdapter usrAuth = new MySqlDataAdapter("SELECT * FROM USERS WHERE username='" + tbUser.Text + "' AND password='" + tbPsswd.Text + "'", myCon);

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM USERS WHERE username='" + tbUser.Text + "'", conn);

                string dataString = "";

                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {


                        if (dr["password"].ToString() == tbPsswd.Text)
                        {
                            if ((int) dr["admin"] == 1)
                            {
                                Menu menu = new Menu(true);
                                this.Hide();
                                menu.ShowDialog();
                                this.Close();
                            }
                            else
                            {
                                Productos productosInter = new Productos(false);
                                this.Hide();
                                productosInter.ShowDialog();
                                this.Close();
                            }
                        }
                        else
                        {
                            System.Diagnostics.Debug.WriteLine("La contrase�a no coincide con el usuario " + dr["username"].ToString());
                        }

                    }

                    if(!dr.HasRows)
                    {
                        System.Diagnostics.Debug.WriteLine("mal mal mal no hay ningun usuario as� en la bbdd");
                    }
                }
            }




        }
    }
}