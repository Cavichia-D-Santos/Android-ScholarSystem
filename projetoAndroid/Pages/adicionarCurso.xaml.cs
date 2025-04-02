namespace projetoAndroid.Pages;

public partial class adicionarCurso : ContentPage
{
	public adicionarCurso()
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
        DisplayAlert("", "CURSO ADICIONADO COM SUCESSO", "VOLTAR");
        etrNomeCurso.Text = "";
        etrSiglaCurso.Text = "";
        etrObsCurso.Text = "";
        pkrDisciplinasCurso.SelectedIndex = -1;
        pkrPeriodoCurso.SelectedIndex = -1;
    }
}