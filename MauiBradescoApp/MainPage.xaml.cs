namespace MauiBradescoApp;
using Pages;

public partial class MainPage : ContentPage
{
	private static NavigationPage MyNavigationPage;
	public MainPage()
	{
		InitializeComponent();
		MyNavigationPage = new NavigationPage();
	}

    private async void onClickRedirectInicio(object sender, EventArgs e)
    {
		await Navigation.PushModalAsync(new HomePage(),true);
    }
}

