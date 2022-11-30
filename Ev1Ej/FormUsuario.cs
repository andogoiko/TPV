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
    public partial class FormUsuario : Form
    {

        private bool add;

        public FormUsuario()
        {
            InitializeComponent();
        }

        public FormUsuario(bool add)
        {
            this.add = add;
            InitializeComponent();
        }

        private void doQuery(object sender, MouseEventArgs e)
        {
            if (add)
            {

            }
            else
            {

            }

            this.Close();

        }
    }
}
