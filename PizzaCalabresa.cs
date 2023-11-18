using Pizzaria.Repositorio;
using Pizzaria.Repositorio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    public class PizzaCalabresa : Pizza
    {
        public PizzaCalabresa( EnumSabores sabores, EnumSabores sabores1) 
        {
            Nome = "Pizza Calabresa";
            massa = "Massa fina e crocante";
            molho = "Molho de tomate italiano";
            ingredientes.Add(sabores.ToString());
            ingredientes.Add(sabores1.ToString());
        }
    }   
}
