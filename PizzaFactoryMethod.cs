using Pizzaria.Repositorio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    public abstract class PizzaFactoryMethod
    {
        public Pizza MontaPizza(string tipo,  EnumSabores sabores, EnumSabores sabores1)
        {
            Pizza pizza;
            pizza = CriarPizza(tipo, sabores, sabores1);
            return pizza;
        }
        protected abstract Pizza CriarPizza(string tipo, EnumSabores sabores, EnumSabores sabores1);
    }
}
