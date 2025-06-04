namespace ASEGURADORAS.formularios
{
    partial class Abank
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonNuevo = new Button();
            buttonCalcular = new Button();
            buttonGuardar = new Button();
            buttonCerrar = new Button();
            buttonEliminar = new Button();
            buttonBuscar = new Button();
            label1 = new Label();
            textBoxNombre = new TextBox();
            label2 = new Label();
            textBoxId = new TextBox();
            label3 = new Label();
            textBoxCarnet = new TextBox();
            label4 = new Label();
            textBoxMonto = new TextBox();
            label5 = new Label();
            textBoxCoPago = new TextBox();
            label6 = new Label();
            textBoxDeducible = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBoxPPaciente = new TextBox();
            label10 = new Label();
            textBoxPAseguradora = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonNuevo
            // 
            buttonNuevo.Location = new Point(86, 392);
            buttonNuevo.Name = "buttonNuevo";
            buttonNuevo.Size = new Size(109, 35);
            buttonNuevo.TabIndex = 0;
            buttonNuevo.Text = " Nuevo";
            buttonNuevo.UseVisualStyleBackColor = true;
            buttonNuevo.Click += buttonNuevo_Click;
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(201, 392);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(109, 35);
            buttonCalcular.TabIndex = 0;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(431, 392);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(109, 35);
            buttonGuardar.TabIndex = 0;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // buttonCerrar
            // 
            buttonCerrar.Location = new Point(667, 392);
            buttonCerrar.Name = "buttonCerrar";
            buttonCerrar.Size = new Size(109, 35);
            buttonCerrar.TabIndex = 0;
            buttonCerrar.Text = "Cerrar";
            buttonCerrar.UseVisualStyleBackColor = true;
            buttonCerrar.Click += buttonCerrar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(546, 392);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(109, 35);
            buttonEliminar.TabIndex = 0;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(316, 392);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(109, 35);
            buttonBuscar.TabIndex = 0;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 150);
            label1.Name = "label1";
            label1.Size = new Size(130, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre del Asegurado";
            label1.Click += label1_Click;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(174, 142);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(481, 23);
            textBoxNombre.TabIndex = 2;
            textBoxNombre.TextChanged += textBoxNombre_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 58);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 1;
            label2.Text = "Id";
            label2.Click += label1_Click;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(174, 55);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(136, 23);
            textBoxId.TabIndex = 2;
            textBoxId.TextAlign = HorizontalAlignment.Right;
            textBoxId.TextChanged += textBoxId_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 96);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 1;
            label3.Text = "Numero de Carnet";
            label3.Click += label1_Click;
            // 
            // textBoxCarnet
            // 
            textBoxCarnet.Location = new Point(174, 93);
            textBoxCarnet.Name = "textBoxCarnet";
            textBoxCarnet.Size = new Size(136, 23);
            textBoxCarnet.TabIndex = 2;
            textBoxCarnet.TextAlign = HorizontalAlignment.Right;
            textBoxCarnet.TextChanged += textBoxCarnet_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 195);
            label4.Name = "label4";
            label4.Size = new Size(112, 15);
            label4.TabIndex = 1;
            label4.Text = "Monto de la Cuenta";
            label4.Click += label1_Click;
            // 
            // textBoxMonto
            // 
            textBoxMonto.Location = new Point(174, 192);
            textBoxMonto.Name = "textBoxMonto";
            textBoxMonto.Size = new Size(136, 23);
            textBoxMonto.TabIndex = 2;
            textBoxMonto.TextAlign = HorizontalAlignment.Right;
            textBoxMonto.TextChanged += textBoxMonto_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 239);
            label5.Name = "label5";
            label5.Size = new Size(119, 15);
            label5.TabIndex = 1;
            label5.Text = "Porcentaje Co - Pago";
            label5.Click += label1_Click;
            // 
            // textBoxCoPago
            // 
            textBoxCoPago.Location = new Point(174, 236);
            textBoxCoPago.Name = "textBoxCoPago";
            textBoxCoPago.Size = new Size(136, 23);
            textBoxCoPago.TabIndex = 2;
            textBoxCoPago.TextAlign = HorizontalAlignment.Right;
            textBoxCoPago.TextChanged += textBoxCoPago_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 300);
            label6.Name = "label6";
            label6.Size = new Size(116, 15);
            label6.TabIndex = 1;
            label6.Text = "Deducible Pendiente";
            label6.Click += label1_Click;
            // 
            // textBoxDeducible
            // 
            textBoxDeducible.Location = new Point(174, 297);
            textBoxDeducible.Name = "textBoxDeducible";
            textBoxDeducible.Size = new Size(136, 23);
            textBoxDeducible.TabIndex = 2;
            textBoxDeducible.TextAlign = HorizontalAlignment.Right;
            textBoxDeducible.TextChanged += textBoxDeducible_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(28, 19);
            label7.Name = "label7";
            label7.Size = new Size(299, 25);
            label7.TabIndex = 1;
            label7.Text = "CALCULO ASEGURADOR ABANK";
            label7.Click += label1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(489, 192);
            label8.Name = "label8";
            label8.Size = new Size(197, 25);
            label8.TabIndex = 1;
            label8.Text = "MONTOS A COBRAR ";
            label8.Click += label1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(377, 239);
            label9.Name = "label9";
            label9.Size = new Size(156, 15);
            label9.TabIndex = 1;
            label9.Text = "MONTO A PAGAR PACIENTE";
            label9.Click += label1_Click;
            // 
            // textBoxPPaciente
            // 
            textBoxPPaciente.Location = new Point(587, 239);
            textBoxPPaciente.Name = "textBoxPPaciente";
            textBoxPPaciente.Size = new Size(136, 23);
            textBoxPPaciente.TabIndex = 2;
            textBoxPPaciente.TextAlign = HorizontalAlignment.Right;
            textBoxPPaciente.TextChanged += textBoxPPaciente_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(377, 300);
            label10.Name = "label10";
            label10.Size = new Size(187, 15);
            label10.TabIndex = 1;
            label10.Text = "MONTO A PAGAR ASEGURADORA";
            label10.Click += label1_Click;
            // 
            // textBoxPAseguradora
            // 
            textBoxPAseguradora.Location = new Point(587, 297);
            textBoxPAseguradora.Name = "textBoxPAseguradora";
            textBoxPAseguradora.Size = new Size(136, 23);
            textBoxPAseguradora.TabIndex = 2;
            textBoxPAseguradora.TextAlign = HorizontalAlignment.Right;
            textBoxPAseguradora.TextChanged += textBoxPAseguradora_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.IBeam;
            pictureBox1.Image = Properties.Resources.Abank;
            pictureBox1.Location = new Point(482, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 124);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // Abank
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxDeducible);
            Controls.Add(textBoxCoPago);
            Controls.Add(label6);
            Controls.Add(textBoxPAseguradora);
            Controls.Add(textBoxPPaciente);
            Controls.Add(textBoxMonto);
            Controls.Add(label5);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(textBoxCarnet);
            Controls.Add(label4);
            Controls.Add(textBoxId);
            Controls.Add(label3);
            Controls.Add(textBoxNombre);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonCerrar);
            Controls.Add(buttonBuscar);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonGuardar);
            Controls.Add(buttonCalcular);
            Controls.Add(buttonNuevo);
            Name = "Abank";
            Text = "Abank";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonNuevo;
        private Button buttonCalcular;
        private Button buttonGuardar;
        private Button buttonCerrar;
        private Button buttonEliminar;
        private Button buttonBuscar;
        private Label label1;
        private TextBox textBoxNombre;
        private Label label2;
        private TextBox textBoxId;
        private Label label3;
        private TextBox textBoxCarnet;
        private Label label4;
        private TextBox textBoxMonto;
        private Label label5;
        private TextBox textBoxCoPago;
        private Label label6;
        private TextBox textBoxDeducible;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBoxPPaciente;
        private Label label10;
        private TextBox textBoxPAseguradora;
        private PictureBox pictureBox1;
    }
}