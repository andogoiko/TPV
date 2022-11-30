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

        public Usuarios()
        {
            InitializeComponent();
        }

        public Usuarios(bool admin)
        {
            this.admin = admin;
            InitializeComponent();
        }

        private void goToMenu(object sender, MouseEventArgs e)
        {
            Menu menu = new Menu(admin);
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }
    }
}
