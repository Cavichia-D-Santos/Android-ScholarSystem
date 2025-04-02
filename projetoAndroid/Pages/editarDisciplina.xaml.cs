namespace projetoAndroid.Pages;

public partial class editarDisciplina : ContentPage
{
	public editarDisciplina()
	{
		InitializeComponent();
	}
    private async void OnClickPaginaConfirmaDelete(object sender, EventArgs e)
    {
        var deletePagina = new confirmaDelete();
        await Navigation.PushModalAsync(deletePagina);
        deletePagina.IsVisible = true;
    }
    private void OnClickPopupConfirmacao(object sender, EventArgs e)
    {
        DisplayAlert("", "DISCIPLINA MODIFICADA COM SUCESSO", "VOLTAR");
        etrEditaNomeDisciplina.Text = "";
        etrEditaSiglaDisciplina.Text = "";
        etrEditaObsDisciplina.Text = "";
    }
}