namespace projetoAndroid.Pages;

public partial class editarPeriodo : ContentPage
{
	public editarPeriodo()
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
        DisplayAlert("", "PERÍODO MODIFICADO COM SUCESSO", "VOLTAR");
        etrEditaNomePeriodo.Text = "";
        etrEditaSiglaPeriodo.Text = "";
    }
}