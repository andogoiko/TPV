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

        public Cuentas()
        {
            InitializeComponent();
        }

        public Cuentas(bool admin)
        {
            this.admin = admin;
            InitializeComponent();
        }

        private void goToMenuCamareros(object sender, MouseEventArgs e)
        {
            MenuCamarero menuCamarero = new MenuCamarero(admin);
            this.Hide();
            menuCamarero.ShowDialog();
            this.Close();
        }
    }
}
