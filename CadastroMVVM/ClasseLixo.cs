using CadastroMVVM.Models;

namespace CadastroMVVM
{
    public class ClasseLixo
    {
        public ClasseLixo()
        {
            //Classe Normal----------------------------------
            ClienteClasseNormal cliente = new ClienteClasseNormal();
            cliente.Nome = "Lucas";
            //cliente = 12xR5;

            ClienteClasseNormal cli2 = new ClienteClasseNormal();
            cli2.Nome = "Igor";
            //cli2 = 8xN1;

            //Classe Singleton----------------------------------
            //Instancia = 4xD1
            var cs = ClienteSingleton.Instancia;
            cs.Nome = "Lucas";

            var clienteSing = ClienteSingleton.Instancia;
            clienteSing.Nome = "Mineiro";

            //cs = 4xD1
            //clienteSing = 4xD1


            //if ternario
            string nome;
            int idade = 18;
            nome = idade >= 18 ? "Lucas" : "Não Identificado";

        }
    }
}
