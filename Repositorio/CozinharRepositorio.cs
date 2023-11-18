using Pizzaria.Repositorio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Repositorio
{
     public class CozinharRepositorio : ICozinhar
    {
        public virtual string Cozinhar()
        {
            return "Cozinhar por 25minutos";
        }
    }
}
