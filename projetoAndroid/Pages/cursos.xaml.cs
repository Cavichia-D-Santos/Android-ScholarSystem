namespace projetoAndroid.Pages;

public partial class cursos : ContentPage
{
	public cursos()
	{
		InitializeComponent();
	}

    private async void OnClickPaginaAdicionarCurso(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new adicionarCurso());
    }

    private async void OnClickPaginaEditarCurso(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new editarCurso());
    }
}