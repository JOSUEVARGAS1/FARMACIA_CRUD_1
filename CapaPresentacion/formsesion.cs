using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frsesion : Form
    {
        CapaEntidad.E_Sesion_Inicio obje = new CapaEntidad.E_Sesion_Inicio();
        CapaNegocio.N_Sesion_Inicio objn = new CapaNegocio.N_Sesion_Inicio();


        public frsesion()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btacceder_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            obje.Usuario = txtusuario.Text;
            obje.Contraseña = txtcontraseña.Text;
            dt = objn.N_Login(obje);

            if (dt .Rows.Count > 0)
            {
                obje.Usuario = dt.Rows[0][0].ToString();
                obje.Contraseña = dt.Rows[0][1].ToString();
                MessageBox.Show("BIENVENIDO" + obje.Usuario);

            }
            else
            {
                MessageBox.Show("ERROR");
            }

        }
    }
}
