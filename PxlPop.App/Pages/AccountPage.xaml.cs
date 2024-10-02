namespace PxlPop.App.Pages;

public partial class AccountPage : ContentPage
{
	public AccountPage()
	{
		InitializeComponent();
	}

	private void OnDarkModeToggled(object sender, ToggledEventArgs e)
	{
		if (darkThemeSwitch.IsToggled)
		{
			Application.Current!.UserAppTheme = AppTheme.Dark;
		}
		else
		{
			Application.Current!.UserAppTheme = AppTheme.Light;
		}
	}

    private void OnPageAppearing(object sender, EventArgs e)
    {
		switch(Application.Current!.UserAppTheme)
		{
			case AppTheme.Dark:
				darkThemeSwitch.IsToggled = true; 
				break;
			default:
				darkThemeSwitch.IsToggled = false;
				break;
		}
    }
}