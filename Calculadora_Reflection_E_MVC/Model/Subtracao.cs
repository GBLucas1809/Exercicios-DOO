using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Operacao = Calculadora_Reflection_E_MVC.Model.Operacao;

namespace Calculadora_Reflection_E_MVC.Model
{
    class Subtracao:Operacao
    {
        public double calcular(double n1, double n2)
        {
            return n1 - n2;
        }
    }
}
