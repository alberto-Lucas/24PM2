using CadastroMVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroMVVM
{
    public class ClasseTeste
    {
        public ClasseTeste() 
        {
            var cliente = ClienteSingleton.Instancia;
            //cliente.Nome -> "Mineiro"
            //cliente = 4xD1

            ClienteClasseNormal cli = new ClienteClasseNormal();
            //cli = 1xB3
        }
    }
}
