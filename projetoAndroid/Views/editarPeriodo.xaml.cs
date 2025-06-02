using projetoAndroid.Model;
namespace projetoAndroid.Views;

public partial class editarPeriodo : ContentPage
{
	public editarPeriodo()
	{
		InitializeComponent();
	}
    private async void BtnAlterar_Clicked(object sender, EventArgs e)
    {
        Periodo p = new Periodo();
        p.Id = int.Parse(etrIdPeriodo.Text);
        p.Nome = etrNomePeriodo.Text;
        p.Sigla = etrSiglaPeriodo.Text;

        await App.Db.Update(p);
        await DisplayAlert("Sucesso", "Registro alterado.", "OK");
        await Navigation.PopAsync();
    }

    private void BtnCancelar_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}