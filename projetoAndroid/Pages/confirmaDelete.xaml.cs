namespace projetoAndroid.Pages;

public partial class confirmaDelete : ContentPage
{
	public confirmaDelete()
	{
		InitializeComponent();
	}

	private async void OnClickedCancela(object sender, EventArgs e)
	{
        await Navigation.PopModalAsync();
    }

    private async void OnClickedConfirma(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}