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
    public partial class formmenu : Form
    {
        public formmenu()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void formmenu_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(cerrarform);
        }
        private void cerrarform(object sender , EventArgs e)
        {
            frsesion frmprincipal = new frsesion();
            this.Hide();
            frmprincipal.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            openform(new Formsoporte());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openform(new Formreporte());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            frsesion frprincipal = new frsesion();
            this.Hide();
            frprincipal.Show();
        }

        private void btproducto_Click(object sender, EventArgs e)
        {
            this.Hide();

            formlistaproducto menu = new formlistaproducto();
            menu.Show();
        }

        private formlistaproducto activeformproducto = null;
        private void openform(formlistaproducto hijopanel1)
        {
            if (activeformproducto != null)
                activeformproducto.Close();
            activeformproducto = hijopanel1;
            hijopanel1.TopLevel = false;
            hijopanel1.FormBorderStyle = FormBorderStyle.None;
            hijopanel1.Dock = DockStyle.Fill;
            panelhijoproducto.Controls.Add(hijopanel1);
            panelhijoproducto.Tag = hijopanel1;
            hijopanel1.BringToFront();
            hijopanel1.Show();


        }

        private void btproducto_Click_1(object sender, EventArgs e)
        {
            openform(new formlistaproducto());
        }

        private formventas activeformventas = null;
        private void openform(formventas hijopanel1)
        {
            if (activeformventas != null)
                activeformventas.Close();
            activeformventas = hijopanel1;
            hijopanel1.TopLevel = false;
            hijopanel1.FormBorderStyle = FormBorderStyle.None;
            hijopanel1.Dock = DockStyle.Fill;
            panelhijoproducto.Controls.Add(hijopanel1);
            panelhijoproducto.Tag = hijopanel1;
            hijopanel1.BringToFront();
            hijopanel1.Show();


        }

        private void btventas_Click(object sender, EventArgs e)
        {
            openform(new formventas());
        }

        private Formcompra activeformcompra = null;
        private void openform(Formcompra hijopanel1)
        {
            if (activeformcompra != null)
                activeformcompra.Close();
            activeformcompra = hijopanel1;
            hijopanel1.TopLevel = false;
            hijopanel1.FormBorderStyle = FormBorderStyle.None;
            hijopanel1.Dock = DockStyle.Fill;
            panelhijoproducto.Controls.Add(hijopanel1);
            panelhijoproducto.Tag = hijopanel1;
            hijopanel1.BringToFront();
            hijopanel1.Show();
        }

        private void btcompras_Click(object sender, EventArgs e)
        {
            openform(new Formcompra());
        }

        private Formreporte activeformreporte = null;
        private void openform(Formreporte hijopanel1)
        {
            if (activeformreporte != null)
                activeformreporte.Close();
            activeformreporte = hijopanel1;
            hijopanel1.TopLevel = false;
            hijopanel1.FormBorderStyle = FormBorderStyle.None;
            hijopanel1.Dock = DockStyle.Fill;
            panelhijoproducto.Controls.Add(hijopanel1);
            panelhijoproducto.Tag = hijopanel1;
            hijopanel1.BringToFront();
            hijopanel1.Show();
        }

        private Formbodega activeformbodega = null;
        private void openform(Formbodega hijopanel1)
        {
            if (activeformbodega != null)
                activeformbodega.Close();
            activeformbodega = hijopanel1;
            hijopanel1.TopLevel = false;
            hijopanel1.FormBorderStyle = FormBorderStyle.None;
            hijopanel1.Dock = DockStyle.Fill;
            panelhijoproducto.Controls.Add(hijopanel1);
            panelhijoproducto.Tag = hijopanel1;
            hijopanel1.BringToFront();
            hijopanel1.Show();
        }

        private void btbodega_Click(object sender, EventArgs e)
        {
            openform(new Formbodega());
        }

        private Formsoporte activeformsoporte = null;
        private void openform(Formsoporte hijopanel1)
        {
            if (activeformsoporte != null)
                activeformsoporte.Close();
            activeformsoporte = hijopanel1;
            hijopanel1.TopLevel = false;
            hijopanel1.FormBorderStyle = FormBorderStyle.None;
            hijopanel1.Dock = DockStyle.Fill;
            panelhijoproducto.Controls.Add(hijopanel1);
            panelhijoproducto.Tag = hijopanel1;
            hijopanel1.BringToFront();
            hijopanel1.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panelbarramenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frsesion frprincipal = new frsesion();
            this.Hide();
            frprincipal.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            frsesion frprincipal = new frsesion();
            this.Hide();
            frprincipal.Show();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            openform(new formlistaproducto());
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            openform(new Formreporte());
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            openform(new formventas());
        }

        private void hora_Tick(object sender, EventArgs e)
        {
            lbhora.Text = DateTime.Now.ToLongTimeString();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            openform(new Formcompra());
        }
    }


}

