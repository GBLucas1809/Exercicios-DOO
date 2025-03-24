using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Calculadora_Reflection_E_MVC.Model;
using Calculadora_Reflection_E_MVC.Control;

namespace Calculadora_Reflection_E_MVC.View
{
    public class Menu
    {
   
        //métodos
        public void exibir(String msg)
        {
            //Carregando instância de Calculadora
            Calculadora calc = new Calculadora();

            //Passando o nome do namescpae
            String model_namesp = "Calculadora_Reflection_E_MVC.Model.";

            //Pegando o cominho do projeto
            String p_directory = AppDomain.CurrentDomain.BaseDirectory;
            p_directory = p_directory.Substring(0, p_directory.IndexOf("bin\\Debug\\net8.0"));
            String model_directory = String.Concat(p_directory, "Model\\");

            //Mostrando as opções de operação no prompt
            Console.WriteLine(msg);

            //Salvando as escolhas do usuário
            String opcao = Console.ReadLine();
            double n1 = 0;
            double n2 = 0;

            //Verificando se a pasta não existe. Se ela não existir retorna mensagem de não encontrado.
            if (!Directory.Exists(model_directory))
            {
                Console.WriteLine("Diretório de operações não encontrado.");
                return;
            }

            while (opcao != "Sair") {
                //Listando cada arquivo .cs da pasta Model e nas subpastas
                String[] cs_files = Directory.GetFiles(model_directory, "*.cs", SearchOption.AllDirectories);

                //Cria variáveel para receber o caminho da classe de operação
                String class_path = "";

                //Itera sobre cada arquivo da pasta model e suas subpastas e adiciona o nome da operacao ao final do nome do namespace
                foreach (string file in cs_files)
                {
                    if (file.Contains(opcao) && class_path == "")
                    {
                        class_path = file;

                        model_namesp = model_namesp + opcao;
                    }
                }

                if (class_path == "")
                {
                    Console.WriteLine("Operacao invalida. Tente novamente\n\n");
                }
                else
                {
                    try
                    {
                        Console.WriteLine("n1: ");
                        n1 = Double.Parse(Console.ReadLine());

                        Console.WriteLine("n2: ");
                        n2 = Double.Parse(Console.ReadLine());

                        if (opcao == "Divisao" && n2 == 0)
                        {
                            Console.WriteLine("Erro. Divisao por zero.\n\n");
                        }
                        else
                        {
                            Console.WriteLine(calc.calcular(model_namesp,n1,n2) + "\n\n");
                        }
                    }
                    catch (FormatException) {
                        Console.WriteLine("Valor de numero invalido.\n\n");
                    }
                    finally
                    {
                        n1 = 0;
                        n2 = 0;
                    }


                }
                model_namesp = "Calculadora_Reflection_E_MVC.Model.";

                Console.WriteLine(msg);
                opcao = Console.ReadLine();
            }

        }
    }
}

