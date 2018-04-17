using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalogo
{
    public partial class Form1 : Form
    {
        Vector v;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtCodigo.Text);
            string nombre = txtNombre.Text;
            string descripcion = txtDes.Text;
            int cantidad = Convert.ToInt32(txtCantidad.Text);
            int costo = Convert.ToInt32(txtCosto.Text);
            v.llenar( codigo, nombre, descripcion, cantidad, costo);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            v = new Vector();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtCodigo.Text);
            textBox6.Text=v.buscar(codigo);           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtCodigo.Text);
            v.eliminar(codigo);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtCodigo.Text);
            string nombre = txtNombre.Text;
            string descripcion = txtDes.Text;
            int cantidad = Convert.ToInt32(txtCantidad.Text);
            int costo = Convert.ToInt32(txtCosto.Text);
            int post = Convert.ToInt16(txtPost.Text);
            v.insertar(codigo, nombre, descripcion, cantidad, costo, post);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox6.Text = v.listar();
        }
    }
}
