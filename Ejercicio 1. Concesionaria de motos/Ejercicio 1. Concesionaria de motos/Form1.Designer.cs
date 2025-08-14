namespace Ejercicio_1._Concesionaria_de_motos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbxMarca = new TextBox();
            dUDModelo = new DomainUpDown();
            dUDAñoCalcular = new DomainUpDown();
            tbxValorFabricacion = new TextBox();
            label6 = new Label();
            tbxTasaDesp = new TextBox();
            tbxVidaUtil = new TextBox();
            btnCalcularCosto = new Button();
            btnCerrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 40);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Marca";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 76);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 1;
            label2.Text = "Modelo(Año)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 119);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 2;
            label3.Text = "Año a Calcular";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 163);
            label4.Name = "label4";
            label4.Size = new Size(116, 15);
            label4.TabIndex = 3;
            label4.Text = "Valor de Fabricacion ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(324, 48);
            label5.Name = "label5";
            label5.Size = new Size(116, 15);
            label5.TabIndex = 4;
            label5.Text = "Tasa de depreciacion";
            // 
            // tbxMarca
            // 
            tbxMarca.Location = new Point(148, 40);
            tbxMarca.Name = "tbxMarca";
            tbxMarca.Size = new Size(100, 23);
            tbxMarca.TabIndex = 5;
            // 
            // dUDModelo
            // 
            dUDModelo.BorderStyle = BorderStyle.FixedSingle;
            dUDModelo.Location = new Point(148, 76);
            dUDModelo.Name = "dUDModelo";
            dUDModelo.Size = new Size(120, 23);
            dUDModelo.TabIndex = 6;
            // 
            // dUDAñoCalcular
            // 
            dUDAñoCalcular.Location = new Point(148, 117);
            dUDAñoCalcular.Name = "dUDAñoCalcular";
            dUDAñoCalcular.Size = new Size(120, 23);
            dUDAñoCalcular.TabIndex = 7;
            // 
            // tbxValorFabricacion
            // 
            tbxValorFabricacion.Location = new Point(148, 160);
            tbxValorFabricacion.Name = "tbxValorFabricacion";
            tbxValorFabricacion.Size = new Size(100, 23);
            tbxValorFabricacion.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(324, 96);
            label6.Name = "label6";
            label6.Size = new Size(94, 15);
            label6.TabIndex = 9;
            label6.Text = "Vida Util (AÑOS)";
            // 
            // tbxTasaDesp
            // 
            tbxTasaDesp.Location = new Point(446, 48);
            tbxTasaDesp.Name = "tbxTasaDesp";
            tbxTasaDesp.Size = new Size(100, 23);
            tbxTasaDesp.TabIndex = 10;
            // 
            // tbxVidaUtil
            // 
            tbxVidaUtil.Location = new Point(446, 93);
            tbxVidaUtil.Name = "tbxVidaUtil";
            tbxVidaUtil.Size = new Size(100, 23);
            tbxVidaUtil.TabIndex = 11;
            // 
            // btnCalcularCosto
            // 
            btnCalcularCosto.Location = new Point(64, 231);
            btnCalcularCosto.Name = "btnCalcularCosto";
            btnCalcularCosto.Size = new Size(133, 27);
            btnCalcularCosto.TabIndex = 12;
            btnCalcularCosto.Text = "Calcular Costo";
            btnCalcularCosto.UseVisualStyleBackColor = true;
            btnCalcularCosto.Click += btnCalcularCosto_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(240, 233);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 13;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCerrar);
            Controls.Add(btnCalcularCosto);
            Controls.Add(tbxVidaUtil);
            Controls.Add(tbxTasaDesp);
            Controls.Add(label6);
            Controls.Add(tbxValorFabricacion);
            Controls.Add(dUDAñoCalcular);
            Controls.Add(dUDModelo);
            Controls.Add(tbxMarca);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbxMarca;
        private DomainUpDown dUDModelo;
        private DomainUpDown dUDAñoCalcular;
        private TextBox tbxValorFabricacion;
        private Label label6;
        private TextBox tbxTasaDesp;
        private TextBox tbxVidaUtil;
        private Button btnCalcularCosto;
        private Button btnCerrar;
    }
}
