using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_HerrP
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblClientes_Click(object sender, EventArgs e)
        {
            ClientesForm clientesForm = new ClientesForm();
            clientesForm.MdiParent = this;
            clientesForm.Show();
        }

        private void lblProductos_Click(object sender, EventArgs e)
        {
            ProductosForm productosForm = new ProductosForm();
            productosForm.MdiParent = this;
            productosForm.Show();
        }

        private void lblSegu_Click(object sender, EventArgs e)
        {
            SeguridadForm seguridadForm = new SeguridadForm();
            seguridadForm.MdiParent = this;
            seguridadForm.Show();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Cientes
        private void administrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientesForm clientesForm = new ClientesForm();
            clientesForm.MdiParent = this;
            clientesForm.Show();
        }

        //Productos
        private void administrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProductosForm productosForm = new ProductosForm();
            productosForm.MdiParent = this;
            productosForm.Show();
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeguridadForm seguridadForm = new SeguridadForm();
            seguridadForm.MdiParent = this;
            seguridadForm.Show();
        }
    }
}
