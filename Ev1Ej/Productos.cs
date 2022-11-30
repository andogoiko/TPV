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
    public partial class Productos : Form
    {

        private bool admin;

        public Productos()
        {
            InitializeComponent();
        }

        public Productos(bool admin)
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

        private void goToLogin(object sender, MouseEventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void goBack(object sender, MouseEventArgs e)
        {
            if (this.admin)
            {
                goToMenu(sender, e);
            }
            else
            {
                goToLogin(sender, e);
            }
        }
    }
}
