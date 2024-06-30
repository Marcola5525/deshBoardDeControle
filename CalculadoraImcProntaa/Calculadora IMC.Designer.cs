namespace CalculadoraImcProntaa
{
    partial class Calculadora
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
            TxtAltura = new TextBox();
            TxtPeso = new TextBox();
            BtCalcular = new Button();
            LbResultado = new Label();
            LbClassificacao = new Label();
            LbIMC = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 36);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Altura";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 94);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 1;
            label2.Text = "Peso";
            // 
            // TxtAltura
            // 
            TxtAltura.Location = new Point(71, 33);
            TxtAltura.Name = "TxtAltura";
            TxtAltura.Size = new Size(135, 23);
            TxtAltura.TabIndex = 2;
            // 
            // TxtPeso
            // 
            TxtPeso.Location = new Point(71, 91);
            TxtPeso.Name = "TxtPeso";
            TxtPeso.Size = new Size(135, 23);
            TxtPeso.TabIndex = 3;
            // 
            // BtCalcular
            // 
            BtCalcular.Location = new Point(71, 149);
            BtCalcular.Name = "BtCalcular";
            BtCalcular.Size = new Size(135, 23);
            BtCalcular.TabIndex = 4;
            BtCalcular.Text = "Calcular IMC";
            BtCalcular.UseVisualStyleBackColor = true;
            BtCalcular.Click += BtCalcular_Click;
            // 
            // LbResultado
            // 
            LbResultado.AutoSize = true;
            LbResultado.Location = new Point(12, 220);
            LbResultado.Name = "LbResultado";
            LbResultado.Size = new Size(59, 15);
            LbResultado.TabIndex = 5;
            LbResultado.Text = "Resultado";
            // 
            // LbClassificacao
            // 
            LbClassificacao.AutoSize = true;
            LbClassificacao.Location = new Point(12, 366);
            LbClassificacao.Name = "LbClassificacao";
            LbClassificacao.Size = new Size(75, 15);
            LbClassificacao.TabIndex = 6;
            LbClassificacao.Text = "Classificação";
            LbClassificacao.Visible = false;
            // 
            // LbIMC
            // 
            LbIMC.AutoSize = true;
            LbIMC.Location = new Point(12, 296);
            LbIMC.Name = "LbIMC";
            LbIMC.Size = new Size(29, 15);
            LbIMC.TabIndex = 7;
            LbIMC.Text = "IMC";
            LbIMC.Visible = false;
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(255, 454);
            Controls.Add(LbIMC);
            Controls.Add(LbClassificacao);
            Controls.Add(LbResultado);
            Controls.Add(BtCalcular);
            Controls.Add(TxtPeso);
            Controls.Add(TxtAltura);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.Black;
            Name = "Calculadora";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TxtAltura;
        private TextBox TxtPeso;
        private Button BtCalcular;
        private Label LbResultado;
        private Label LbClassificacao;
        private Label LbIMC;
    }
}
