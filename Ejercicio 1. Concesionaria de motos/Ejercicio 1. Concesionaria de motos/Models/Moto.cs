using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1._Concesionaria_de_motos.Models
{
    internal class Moto
    {
        
        public string Marca { get; }      
        public int Modelo { get; }        
        public double ValorFabricacion { get; } 

        public Moto(string marca, int modelo, double valorFabricacion)
        {
            Marca = marca;
            Modelo = modelo;
            ValorFabricacion = valorFabricacion;
        }

        public double CalcularDepreciacionLineal(int añoACalcular, int vidaUtil)
        {
            int añosDeUso = añoACalcular - Modelo;
            double valorActualizado = ValorFabricacion - (ValorFabricacion * (añoACalcular - Modelo) / vidaUtil);
            return valorActualizado;
        }

        public double CalcularDepreciacionAnual (int añoACalcular, double tasaDepreciacion)
        {
            int añosDeUso = añoACalcular - Modelo;
            return ValorFabricacion * Math.Pow(1 - tasaDepreciacion, añoACalcular - Modelo);
           
        }

        public string VerDescripcion()
        {
            return $"marca: {Marca} \n\r modelo: {Modelo} \n\r valor fabriación:$ {ValorFabricacion,10:f2} \n\r";
        }



    }
}

