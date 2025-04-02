namespace projetoAndroid.Pages;

public partial class adicionarPeriodo : ContentPage
{
	public adicionarPeriodo()
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
		DisplayAlert("", "PERÍODO ADICIONADO COM SUCESSO", "VOLTAR");
		etrNomePeriodo.Text = "";
		etrSiglaPeriodo.Text = "";
	}
}