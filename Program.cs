using Pizzaria.Repositorio.Interface;
using Pizzaria.Repositorio;
using static Pizzaria.Program;
using System.Diagnostics;

namespace Pizzaria
{
    internal class Program
    {

        static void Main(string[] args)
        {
            
            

            Console.WriteLine("Bem-vindo escolha sua pizza c => Calabresa e m => Mussarela");
            var sabor = Console.ReadLine().ToUpper();
            Console.WriteLine("qual sua escolha");
            var escolha1 = Console.ReadLine().ToUpper();
            var valor = Int32.Parse(escolha1);
            Console.WriteLine("Qual sua segunda opcao");
            var escolha2 = Console.ReadLine().ToUpper();
            var valor2 = Int32.Parse(escolha2);
            try
            {
                ICozinhar cozinhar = new CozinharRepositorio();
                EnumSabores sabores = (EnumSabores)valor;
                EnumSabores sabores1 = (EnumSabores)valor2;
                PizzaFactoryMethod pizza;
                Console.Clear();
                
                
               
                pizza = new PizzariaFactory();
                Console.Write(cozinhar.Cozinhar());

                TimerClock1 timer = new();
                

                var p = pizza.MontaPizza(sabor, sabores, sabores1);
              
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(p.Preparar());

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro" + ex.Message);
            }
            Console.ReadLine();

        }

    }
}