using Ejercicio_1._Concesionaria_de_motos.Models;

namespace Ejercicio_1._Concesionaria_de_motos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalcularCosto_Click(object sender, EventArgs e)
        {

            Ver_Resultados resultados = new Ver_Resultados();

            Moto moto = new Moto
                (
                tbxMarca.Text, 
                Convert.ToInt32(dUDModelo.Text),
                Convert.ToDouble(tbxValorFabricacion.Text)
                );

            double DepreciacionLineal = moto.CalcularDepreciacionLineal(Convert.ToInt32(dUDAñoCalcular.Text), Convert.ToInt32(tbxVidaUtil.Text));
            double DepreciacionAnual = moto.CalcularDepreciacionAnual(Convert.ToInt32(dUDAñoCalcular.Text), Convert.ToDouble(tbxTasaDesp.Text));


            resultados.tbxResultado.Text = moto.VerDescripcion() +
              $"Depreciación lineal:{DepreciacionLineal}\n\r" +
              $"Depreciación anual: {DepreciacionAnual}\n\r";

            resultados.ShowDialog();
        }

           


        
    }
}
