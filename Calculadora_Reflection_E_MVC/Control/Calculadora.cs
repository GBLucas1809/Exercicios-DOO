using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Calculadora_Reflection_E_MVC.Model;
using Calculadora_Reflection_E_MVC.Factory;

namespace Calculadora_Reflection_E_MVC.Control
{
    public class Calculadora
    {
        public double calcular(String operacao,double n1, double n2)
        {
            try {
                //Pegando o tipo da operacao passada
                Type tipo_operacao = Type.GetType(operacao);

                //Criando uma instancia do tipo passado usando método fábrica 
                Object instancia_op = OperacaoFactory.createObject(operacao);
            
                //Invoca o método da operacao e retorna o resultado gerado pelo método
                double resultado = (double)tipo_operacao.GetMethod("calcular").Invoke(instancia_op, new object[] { n1, n2 });


                return resultado;
            }
            catch (ReflectionTypeLoadException err)
            {
                Console.WriteLine("Erro de carregamento de tipo (reflection): " + err);
                return -1;
            }
            catch (ArgumentNullException err) {
                Console.WriteLine("Outro erro.");
                return -1;
            }
            catch (DivideByZeroException err)
            {
                Console.WriteLine("Erro. Divisao por zero.");
                return -1;
            }
        }

    }
}
