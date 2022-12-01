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
    public partial class MenuCamarero : Form
    {

        private bool admin;

        public MenuCamarero()
        {
            InitializeComponent();
        }

        public MenuCamarero(bool admin)
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

        private void goToCuentas(object sender, MouseEventArgs e)
        {
            Cuentas productos = new Cuentas(admin);
            this.Hide();
            productos.ShowDialog();
            this.Close();
        }
    }
}
