namespace PxlPop.App.Pages;

public partial class OrderPage : ContentPage
{
	public OrderPage()
	{
		InitializeComponent();
	}

    private async void OnPaymentClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//MainPage", true);
    }
}