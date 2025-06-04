namespace ASEGURADORAS.formularios
{
    partial class Principal
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
            buttonAcssa = new Button();
            buttonAbank = new Button();
            buttonAssa = new Button();
            buttonAsesuiza = new Button();
            buttonMapfre = new Button();
            buttonPalic = new Button();
            buttonQualitas = new Button();
            buttonCerrar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonAcssa
            // 
            buttonAcssa.Location = new Point(57, 99);
            buttonAcssa.Name = "buttonAcssa";
            buttonAcssa.Size = new Size(114, 54);
            buttonAcssa.TabIndex = 0;
            buttonAcssa.Text = "Acsa";
            buttonAcssa.UseVisualStyleBackColor = true;
            buttonAcssa.Click += buttonAcssa_Click;
            // 
            // buttonAbank
            // 
            buttonAbank.Location = new Point(57, 15);
            buttonAbank.Name = "buttonAbank";
            buttonAbank.Size = new Size(114, 54);
            buttonAbank.TabIndex = 0;
            buttonAbank.Text = "Abank";
            buttonAbank.UseVisualStyleBackColor = true;
            buttonAbank.Click += buttonAbank_Click;
            // 
            // buttonAssa
            // 
            buttonAssa.Location = new Point(57, 256);
            buttonAssa.Name = "buttonAssa";
            buttonAssa.Size = new Size(114, 54);
            buttonAssa.TabIndex = 0;
            buttonAssa.Text = "Assa";
            buttonAssa.UseVisualStyleBackColor = true;
            buttonAssa.Click += buttonAssa_Click;
            // 
            // buttonAsesuiza
            // 
            buttonAsesuiza.Location = new Point(57, 171);
            buttonAsesuiza.Name = "buttonAsesuiza";
            buttonAsesuiza.Size = new Size(114, 54);
            buttonAsesuiza.TabIndex = 0;
            buttonAsesuiza.Text = "Asesuiza";
            buttonAsesuiza.UseVisualStyleBackColor = true;
            buttonAsesuiza.Click += buttonAsesuiza_Click;
            // 
            // buttonMapfre
            // 
            buttonMapfre.Location = new Point(57, 341);
            buttonMapfre.Name = "buttonMapfre";
            buttonMapfre.Size = new Size(114, 54);
            buttonMapfre.TabIndex = 0;
            buttonMapfre.Text = "Mapfre";
            buttonMapfre.UseVisualStyleBackColor = true;
            buttonMapfre.Click += buttonMapfre_Click;
            // 
            // buttonPalic
            // 
            buttonPalic.ImageAlign = ContentAlignment.BottomCenter;
            buttonPalic.Location = new Point(283, 341);
            buttonPalic.Name = "buttonPalic";
            buttonPalic.Size = new Size(114, 54);
            buttonPalic.TabIndex = 0;
            buttonPalic.Text = "Palic";
            buttonPalic.UseVisualStyleBackColor = true;
            buttonPalic.Click += buttonPalic_Click;
            // 
            // buttonQualitas
            // 
            buttonQualitas.ImageAlign = ContentAlignment.BottomCenter;
            buttonQualitas.Location = new Point(429, 341);
            buttonQualitas.Name = "buttonQualitas";
            buttonQualitas.Size = new Size(114, 54);
            buttonQualitas.TabIndex = 0;
            buttonQualitas.Text = "Qualitas";
            buttonQualitas.UseVisualStyleBackColor = true;
            buttonQualitas.Click += buttonQualitas_Click;
            // 
            // buttonCerrar
            // 
            buttonCerrar.ImageAlign = ContentAlignment.BottomCenter;
            buttonCerrar.Location = new Point(562, 341);
            buttonCerrar.Name = "buttonCerrar";
            buttonCerrar.Size = new Size(114, 54);
            buttonCerrar.TabIndex = 0;
            buttonCerrar.Text = "Cerrar";
            buttonCerrar.UseVisualStyleBackColor = true;
            buttonCerrar.Click += buttonCerrar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.upes;
            pictureBox1.Location = new Point(343, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 168);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(buttonCerrar);
            Controls.Add(buttonQualitas);
            Controls.Add(buttonPalic);
            Controls.Add(buttonMapfre);
            Controls.Add(buttonAssa);
            Controls.Add(buttonAsesuiza);
            Controls.Add(buttonAbank);
            Controls.Add(buttonAcssa);
            Name = "Principal";
            Text = "Principal";
            Load += Principal_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAcssa;
        private Button buttonAbank;
        private Button buttonAssa;
        private Button buttonAsesuiza;
        private Button buttonMapfre;
        private Button buttonPalic;
        private Button buttonQualitas;
        private Button buttonCerrar;
        private PictureBox pictureBox1;
    }
}