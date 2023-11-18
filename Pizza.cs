
using Pizzaria.Repositorio;
using Pizzaria.Repositorio.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
     public abstract class Pizza
    {
        protected string Nome { get; set; }
        protected string massa;
        protected string molho;
        protected List<string> ingredientes = new();

       
       
        public string Preparar()
        {   
            StringBuilder sb = new();
            sb.Append("Preparando " + Nome + "\n" );
            sb.Append(massa + "\n");
            sb.Append(molho + "\n");
            sb.Append("Igredientes: " + "\n");
            foreach (string ingrediente in ingredientes)
            {
                sb.Append("\t" +  ingrediente + "\n");   
            }
           
         

            
                      
            return sb.ToString();
        } 
    }
}
