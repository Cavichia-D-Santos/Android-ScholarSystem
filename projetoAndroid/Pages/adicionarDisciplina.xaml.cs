namespace projetoAndroid.Pages;

public partial class adicionarDisciplina : ContentPage
{
	public adicionarDisciplina()
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
        DisplayAlert("", "DISCIPLINA ADICIONADA COM SUCESSO", "VOLTAR");
        etrNomeDisciplina.Text = "";
        etrSiglaDisciplina.Text = "";
        etrObsDisciplina.Text = "";
    }
}