using projetoAndroid.Model;
using System.Collections.ObjectModel;

namespace projetoAndroid.Pages;

public partial class adicionarPeriodo : ContentPage
{
	public adicionarPeriodo()
	{
		InitializeComponent();
	}

	private async void btnInserir_Clicked(object sender, EventArgs e)
	{
		if(etrNome.Text == null)
		{
			await DisplayAlert("ATENÇÃO", "O campo nome não pode ser vazio.", "OK");
		} else
		{
			Periodo p = new Periodo();
			p.Nome = etrNome.Text;
			p.Sigla = etrSigla.Text;

			await App.Db.Insert(p);
			await DisplayAlert("SUCESSO", "Registro inserido", "OK");
			await Navigation.PopAsync();
		}
	}

    private void BtnCancelar_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}