using Pizzaria.Repositorio;
using Pizzaria.Repositorio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    public class PizzariaFactory : PizzaFactoryMethod
    {   
      

        protected override Pizza CriarPizza(string tipo, EnumSabores sabores, EnumSabores sabores1)
        {
            if (tipo.Equals("C"))
            {
                return new PizzaCalabresa( sabores, sabores1);
            }
            if (tipo.Equals("M"))
            {
                return new PizzaMussarela( sabores, sabores1);
            }
            else return null;
        }
    }
}
