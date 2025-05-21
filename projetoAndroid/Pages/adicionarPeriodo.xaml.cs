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

			await App.Db.Insert(p);
			await DisplayAlert("SUCESSO", "Registro inserido", "OK");
			await Navigation.PopAsync();
		}
	}
}

/*var deletePagina = new confirmaDelete();
await Navigation.PushModalAsync(deletePagina);

deletePagina.IsVisible = true;*/