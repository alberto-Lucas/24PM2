using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationLogin
{
    //Criar uma classe ESTATICA com metodos
    //de animação de componentes
    //Uma classe STATIC não precisa ser
    //instanciada, ou seja, é alocada em memoria
    //ao inicializar a aplicação
    public static class Animation
    {
        //Em classe estatica, os métodos
        //tambem precisam ser do tipo static

        //Criar um método para aplicar uma
        //animação de tremor, em qualquer
        //componenete visual
        static public async void Tremer(
            VisualElement elemento)
        {
            //Validar se o componente não esta nullo
            if (elemento == null)
                return;

            uint tempo = 50;

            //Lista com os valores de deslocamento
            var deslocamento =
                new[] {-15, 15, -10, 10, -5, 5 };

            //Aplicar um loop para cada item da lista
            foreach(var deslocar in deslocamento)
            {
                await elemento.
                    TranslateTo(deslocar, 0, tempo);
            }

            elemento.TranslationX = 0;
        }
    }
}
