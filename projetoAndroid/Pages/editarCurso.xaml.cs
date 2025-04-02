namespace projetoAndroid.Pages;

public partial class editarCurso : ContentPage
{
	public editarCurso()
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
        DisplayAlert("", "CURSO MODIFICADO COM SUCESSO", "VOLTAR");
        etrEditaNomeCurso.Text = "";
        etrEditaSiglaCurso.Text = "";
        etrEditaObsCurso.Text = "";
        pkrEditaDisciplinasCurso.SelectedIndex = -1;
        pkrPeriodoCurso.SelectedIndex = -1;
    }
}