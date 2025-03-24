// See https://aka.ms/new-console-template for more information
using Calculadora_Reflection_E_MVC.View;

/*Author: Gabriel Barbosa Lucas*/
public class App
{
    public static void Main(String[] argv)
    {

        String msg = @"Escreva o nome da operacao desejada:
    -> Soma
    -> Subtracao
    -> Multiplicacao
    -> Divisao
    -> Sair"+"\n \n->";//O formato @"" permite escrever as strings com quebra de linha

        Menu menu = new();
        menu.exibir(msg);
    }

    
}