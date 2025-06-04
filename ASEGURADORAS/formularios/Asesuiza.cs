using ASEGURADORAS.Models;
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
    public partial class Asesuiza : Form
    {
        public Asesuiza()
        {
            InitializeComponent();
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            var calculadora = new CalculadoraPagoSeguro
            {
                MontoTotal = decimal.TryParse(textBoxMonto.Text, out var monto) ? monto : 0,
                Deducible = decimal.TryParse(textBoxDeducible.Text, out var deducible) ? deducible : 0,
                CopagoPorcentaje = decimal.TryParse(textBoxCoPago.Text, out var copago) ? copago : 0
            };

            if (calculadora.Calcular())
            {
                textBoxPPaciente.Text = Math.Round(calculadora.PagoPaciente, 2).ToString();
                textBoxPAseguradora.Text = Math.Round(calculadora.PagoAseguradora, 2).ToString();
            }
            else
            {
                MessageBox.Show("Verifique los datos ingresados.");
            }
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            Limpiar.Controles(this);
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (string.IsNullOrWhiteSpace(textBoxCarnet.Text) ||
                    string.IsNullOrWhiteSpace(textBoxNombre.Text))
                {
                    MessageBox.Show("Carnet y Nombre son obligatorios.");
                    return;
                }

                
                if (!decimal.TryParse(textBoxMonto.Text, out var monto))
                {
                    MessageBox.Show("El valor de Monto Total no es válido.");
                    return;
                }

                if (!decimal.TryParse(textBoxCoPago.Text, out var copago))
                {
                    MessageBox.Show("El valor de Copago no es válido.");
                    return;
                }

                if (!decimal.TryParse(textBoxDeducible.Text, out var deducible))
                {
                    MessageBox.Show("El valor de Deducible no es válido.");
                    return;
                }

                if (!decimal.TryParse(textBoxPPaciente.Text, out var pagoPaciente))
                {
                    MessageBox.Show("El valor de Pago del Paciente no es válido.");
                    return;
                }

                if (!decimal.TryParse(textBoxPAseguradora.Text, out var pagoAseguradora))
                {
                    MessageBox.Show("El valor de Pago de la Aseguradora no es válido.");
                    return;
                }

                
                using (var context = new ASEGURADORAS.Data.ApplicationDbContext())
                {
                    var nuevaEntrada = new AsesuizaPago
                    {
                        Carnet = textBoxCarnet.Text.Trim(),
                        Nombre = textBoxNombre.Text.Trim(),
                        MontoTotal = monto,
                        CopagoPorcentaje = copago,
                        Deducible = deducible,
                        PagoPaciente = pagoPaciente,
                        PagoAseguradora = pagoAseguradora
                        
                    };

                    context.AsesuizaPagos.Add(nuevaEntrada);
                    context.SaveChanges();

                    MessageBox.Show("Datos guardados correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                var carnetBuscado = textBoxCarnet.Text.Trim();

                if (string.IsNullOrWhiteSpace(carnetBuscado))
                {
                    MessageBox.Show("Ingrese un Carnet para buscar.");
                    return;
                }

                using (var context = new ASEGURADORAS.Data.ApplicationDbContext())
                {
                    var resultado = context.AsesuizaPagos.FirstOrDefault(p => p.Carnet == carnetBuscado);

                    if (resultado != null)
                    {
                        textBoxNombre.Text = resultado.Nombre;
                        textBoxMonto.Text = resultado.MontoTotal.ToString();
                        textBoxCoPago.Text = resultado.CopagoPorcentaje.ToString();
                        textBoxDeducible.Text = resultado.Deducible.ToString();
                        textBoxPPaciente.Text = resultado.PagoPaciente.ToString();
                        textBoxPAseguradora.Text = resultado.PagoAseguradora.ToString();

                        MessageBox.Show("Registro encontrado.");
                    }
                    else
                    {
                        MessageBox.Show("No se encontró un registro con ese Carnet.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }
    }
}
