using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDePresentacion
{
    public partial class formlistaproducto : Form
    {
        public formlistaproducto()
        {
            InitializeComponent();
        }

        private void btvolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
