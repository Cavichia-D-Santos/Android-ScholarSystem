namespace projetoAndroid.Pages;

public partial class editarPeriodo : ContentPage
{
	public editarPeriodo()
	{
		InitializeComponent();
	}

    private void ConfirmaEdicao_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("", "PERÍODO MODIFICADO COM SUCESSO", "VOLTAR");
        etrEditaNomePeriodo.Text = "";
        etrEditaSiglaPeriodo.Text = "";
    }

    private async void BtnVoltar_Clicked(object sender, EventArgs e)
    {
        var deletePagina = new confirmaDelete();
        await Navigation.PushModalAsync(deletePagina);
        deletePagina.IsVisible = true;
    }
}