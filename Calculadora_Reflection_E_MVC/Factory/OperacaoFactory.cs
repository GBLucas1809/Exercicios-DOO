using Calculadora_Reflection_E_MVC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Calculadora_Reflection_E_MVC.Factory
{
    class OperacaoFactory
    {
        public static object createObject(String class_name)
        {
            //Pegando o tipo da operação pelo nome passado
            Type tipo_operacao = Type.GetType(class_name);

            String single_class_name = class_name.Substring(class_name.LastIndexOf('.') + 1);

            if (tipo_operacao != null)
            {
                //Se o tipo retornado não for nulo, retorna uma nova instância de objeto desse tipo
                return Activator.CreateInstance(tipo_operacao);
            }
            else
            {
                //Caso seja nulo, retorna uma mensagem de erro
                throw new NullReferenceException("Classe invalida: " + single_class_name);
            }


            //Retornando a instância desse objeto

            
        }
    }
}
