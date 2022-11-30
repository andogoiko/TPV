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

        public FormProducto()
        {
            InitializeComponent();
        }

        public FormProducto(bool add)
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
