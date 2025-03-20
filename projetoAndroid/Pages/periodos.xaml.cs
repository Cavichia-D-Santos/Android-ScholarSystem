namespace projetoAndroid.Pages;

public partial class periodos : ContentPage
{
	public periodos()
	{
		InitializeComponent();
	}

	private async void OnClickPaginaAdicionarPeriodo(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new adicionarPeriodo());
	}

    private async void OnClickPaginaEditarPeriodo(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new editarPeriodo());
    }
}