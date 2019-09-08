using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoVisual
{
    public partial class Form1 : Form
    {
        Point txtCodigoPoint = new Point (77, 8);

        public Form1()
        {
            InitializeComponent();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length == txtCodigo.MaxLength)
            {
                MessageBox.Show(txtCodigo.Text);
            }
        }

        private void comboTeste_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (comboTeste.SelectedItem != null 
                && comboTeste.SelectedItem.ToString() == "Sim"
                && checkBox1.Checked
                && radioButton1.Checked)
            {
                this.txtCodigo.Location = e.Location;
            } else
            {
                this.txtCodigo.Location = txtCodigoPoint;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();

            f2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
