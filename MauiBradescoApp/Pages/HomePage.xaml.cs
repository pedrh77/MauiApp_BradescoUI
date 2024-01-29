namespace MauiBradescoApp.Pages;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}

    private void onLogoutClicked(object sender, EventArgs e)
    {
		
		Navigation.PushModalAsync(new MainPage(), true);
    }
}