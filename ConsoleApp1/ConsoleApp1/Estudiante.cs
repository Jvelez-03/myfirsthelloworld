using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Estudiante
    {
        public int Creditos { get; set; }
        public int Estrato { get; set; }
        public decimal ValorCredito { get; set; }

        public Estudiante(int creditos, int estrato, decimal valorCredito)
        {
            Creditos = creditos;
            Estrato = estrato;
            ValorCredito = valorCredito;
        }

        public decimal CalcularMatricula()
        {
            decimal costo = Creditos > 20 ? (20 * ValorCredito) + (Creditos - 20) * ValorCredito * 2 : Creditos * ValorCredito;
            decimal descuento = Estrato == 1 ? 0.2m : Estrato == 2 ? 0.5m : Estrato == 3 ? 0.7m : 1;
            return costo * descuento;
        }

        public decimal CalcularSubsidio() => Estrato == 1 ? 200000 : Estrato == 2 ? 100000 : 0;
    }

}
