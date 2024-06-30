namespace CalculadoraImcProntaa
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void BtCalcular_Click(object sender, EventArgs e)
        {

            double peso = Convert.ToDouble(TxtPeso.Text);
            double altura = Convert.ToDouble(TxtAltura.Text);

            double imc = peso / (altura * altura);

            LbIMC.Text = imc.ToString("F2");
            LbIMC.Visible = true;

            string classificacao = string.Empty;

            if (imc < 18.5)
                classificacao = "Voc� est� Abaixo do peso";
            else if (imc <= 24.9)
                classificacao = "Voc� est� no peso Normal";
            else if (imc <= 29.9)
                classificacao = "Voc� est� Sobepreso";
            else if (imc >= 30.0)
                classificacao = "Voc� est� Obeso";

            LbClassificacao.Text = classificacao;
            LbClassificacao.Visible = true;
        }
    }
}
