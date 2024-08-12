namespace SplashScreen
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnGirarDireitaClicked(object sender, EventArgs e)
        {
            imgTeste.Rotation = 0; //posição inicial
            imgTeste.RotateTo(360, 2000); //graus de giro e tempo para girar
        }

        private void btnGirarEsquerdaClicked(object sender, EventArgs e)
        {
            imgTeste.Rotation = 0;
            imgTeste.RotateTo(-360, 2000);
        }

        private void btnGirarVerticalClicked(object sender, EventArgs e)
        {
            imgTeste.RotationY = 0;
            imgTeste.RotateYTo(360, 2000);
        }

        private void btnGirarHorizontalClicked(object sender, EventArgs e)
        {
            imgTeste.RotationX = 0;
            imgTeste.RotateXTo(360, 2000);
        }

        private void btnZoomMaisClicked(object sender, EventArgs e)
        {
            imgTeste.ScaleTo(imgTeste.Scale + 0.5, 250);
        }

        private void btnZoomMenosClicked(object sender, EventArgs e)
        {
            imgTeste.ScaleTo(imgTeste.Scale - 0.5, 250);
        }

        private void btnTremerClicked(object sender, EventArgs e)
        {
            Tremer(50);
        }

        async void Tremer(uint tempo)
        {
            //vamos literalmente movimentar a imagem da esquerda para direita
            await imgTeste.TranslateTo(-15, 0, tempo);
            await imgTeste.TranslateTo(15, 0, tempo);
            await imgTeste.TranslateTo(-10, 0, tempo);
            await imgTeste.TranslateTo(10, 0, tempo);
            await imgTeste.TranslateTo(-5, 0, tempo);
            await imgTeste.TranslateTo(5, 0, tempo);
            imgTeste.TranslationX = 0;
        }

        private async void btnGirarZoomMaisClicked(object sender, EventArgs e)
        {
            imgTeste.Rotation = 0;
            await Task.WhenAny<bool> //criamos uma task para girar a imagem em segundo plano
            (
              imgTeste.RotateTo(360, 2000),
              imgTeste.ScaleTo(2, 1000)
            );
            await imgTeste.ScaleTo(1, 1000);
        }

        private async void btnFadeClicked(object sender, EventArgs e)
        {
            imgTeste.Opacity = 1;
            await imgTeste.FadeTo(0, 500);

            imgTeste.Opacity = 0;
            await imgTeste.FadeTo(1, 500);
            //imgTeste.FadeTo(1, 4000);
        }
    }
}
