using Pizzaria.Repositorio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    public class PizzaMussarela : Pizza
    {   
        public PizzaMussarela( EnumSabores _sabores, EnumSabores _sabores1 )
        {
            Nome = "Pizza Mussarela";
            massa = "Massa com azeite";
            molho = "Molho de tomate cereja";
            ingredientes.Add(_sabores.ToString());
            ingredientes.Add(_sabores1.ToString());   
        }
    }
}
