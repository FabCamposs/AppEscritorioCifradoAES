using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDesktopCifradoAES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnCifrar_Click(object sender, EventArgs e)
        {
            string Texto,Password, Vector;
            int interacciones;

            try
            {
                Texto = txtTexto.Text;
                Password = txtPassword.Text;
                Vector = txtVector.Text;
                interacciones = int.Parse(txtSaltos.Text);
                var Cifrado = new ClaseCifradoAES();
                txtCifrado.Text = Cifrado.CifradoAES(Texto, Password, Vector, interacciones);


            }
            
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDescifrar_Click(object sender, EventArgs e)
        {

            string Texto, Password, Vector;
            int interacciones;

            try
            {
                Texto = txtCifrado.Text;
                Password = txtPassword.Text;
                Vector = txtVector.Text;
                interacciones = int.Parse(txtSaltos.Text);
                var Descifrado = new ClaseCifradoAES();
                txtTexto.Text = Descifrado.DescifradoAES(Texto, Password, Vector, interacciones);


            }

            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
