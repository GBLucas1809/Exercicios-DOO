using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Reflection_E_MVC.Model
{
    public interface Operacao
    {
        public double calcular(double n1, double n2);
    }
}
