namespace projetoAndroid.Pages;

public partial class disciplinas : ContentPage
{
	public disciplinas()
	{
		InitializeComponent();
	}

    private async void OnClickPaginaAdicionarDisciplina(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new adicionarDisciplina());
    }

    private async void OnClickPaginaEditarDisicplina(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new editarDisciplina());
    }
}