using ASEGURADORAS.Data;
using ASEGURADORAS.Models;
using ASEGURADORAS.formularios; 
using System;
using System.Linq;
using System.Windows.Forms;

namespace ASEGURADORAS
{
    public partial class Contrase�a : Form
    {
        public Contrase�a()
        {
            InitializeComponent();
        }

        private void login()
        {
            using (var context = new ApplicationDbContext())
            {
                var usuario = textBox1.Text.Trim();
                var clave = textBox2.Text.Trim();

                var usuarioValido = context.Contrase�as
                    .FirstOrDefault(u => u.NombreUsuario == usuario && u.Clave == clave);

                if (usuarioValido != null)
                {
                    Principal formPrincipal = new Principal();
                    formPrincipal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contrase�a incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Contrase�a_Load(object sender, EventArgs e)
        {
            
        }
    }
}
