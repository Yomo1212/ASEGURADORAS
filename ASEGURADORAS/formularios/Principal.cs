using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASEGURADORAS.formularios
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAbank_Click(object sender, EventArgs e)
        {
            Abank abank = new Abank();
            abank.Show();
        }

        private void buttonAcssa_Click(object sender, EventArgs e)
        {
            Acsa acsa = new Acsa();
            acsa.Show();

        }

        private void buttonAsesuiza_Click(object sender, EventArgs e)
        {
            Asesuiza asesuiza = new Asesuiza();
            asesuiza.Show();

        }

        private void buttonAssa_Click(object sender, EventArgs e)
        {
            Assa assa = new Assa();
            assa.Show();
        }

        private void buttonMapfre_Click(object sender, EventArgs e)
        {
            Mapfre mapfre = new Mapfre();
            mapfre.Show();
        }

        private void buttonPalic_Click(object sender, EventArgs e)
        {
            Palic palic = new Palic();
            palic.Show();
        }

        private void buttonQualitas_Click(object sender, EventArgs e)
        {
            Qualitas quialitas = new Qualitas();
            quialitas.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
