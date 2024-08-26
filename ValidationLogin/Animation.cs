namespace ValidationLogin
{
    public static class Animation
    {
        //Criamos um método generico que
        //ira receber um componente como parametros
        //e iremos aplicar uma animção de tremor
        //Podemos aplicar esta animação em qualquer componente
        static public async void Tremer(VisualElement elemento)
        {
            //Validação caso o componente seja Nulo
            if (elemento == null)
                return;

            uint tempo = 50;

            // Lista de deslocamentos para a animação de tremor
            var deslocamentos = new[] {-15, 15, -10, 10, -5, 5 };

            foreach (var deslocamento in deslocamentos)
            {
                await elemento.TranslateTo(deslocamento, 0, tempo);
            }

            elemento.TranslationX = 0;
        }
    }
}
