namespace SplashScreen;

public partial class pgSplashScreen : ContentPage
{
	public pgSplashScreen()
	{
		InitializeComponent();

        AnimateImage();
    }

    async void AnimateImage()
    {
        await Task.Delay(2000);
        imgWord.Rotation = 0;
        imgWord.RotateTo(360, 3000);
        imgWord.Rotation = 0;
        await Task.Delay(2000);

        await imgWord.ScaleTo(1.5, 2000, Easing.Linear);
        await imgWord.ScaleTo(1, 1000, Easing.Linear);
        await imgWord.ScaleTo(0.5, 1500, Easing.Linear);
        await imgWord.ScaleTo(150, 1500, Easing.Linear);

        Application.Current.MainPage = new NavigationPage(new MainPage());
    }

    private void btnMainPage_Clicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new NavigationPage(new MainPage());
    }
}