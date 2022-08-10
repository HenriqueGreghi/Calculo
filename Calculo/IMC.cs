using System;
using System.Collections.Generic;
using System.Text;

namespace Calculo
{
    class IMC
    {
        public double Peso;
        public double Altura;

        public double ValorImc()
        {
            return  Peso / (Altura * Altura);
        }
    }
}
