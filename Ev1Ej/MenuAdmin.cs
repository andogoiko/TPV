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
    public partial class MenuAdmin : Form
    {

        private bool admin;
        public MenuAdmin()
        {
            InitializeComponent();
        }

        public MenuAdmin(bool admin)
        {
            this.admin = admin;
            InitializeComponent();
        }

        private void goToLogin(object sender, MouseEventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void goToProductos(object sender, MouseEventArgs e)
        {
            Productos productos = new Productos(admin);
            this.Hide();
            productos.ShowDialog();
            this.Close();
        }

        private void goToUsuarios(object sender, MouseEventArgs e)
        {
            Usuarios usuarios = new Usuarios(admin);
            this.Hide();
            usuarios.ShowDialog();
            this.Close();
        }
    }
}
