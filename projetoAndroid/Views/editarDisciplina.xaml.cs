using projetoAndroid.Model;
using System.ComponentModel.DataAnnotations;

namespace projetoAndroid.Views;

public partial class editarDisciplina : ContentPage
{
	public editarDisciplina()
	{
		InitializeComponent();
	}

	private async void BtnAlterar_Clicked(object sender, EventArgs e)
	{
        Disciplina p = new Disciplina();
        p.Id = int.Parse(etrEditaIdDisciplina.Text);
        p.Nome = etrEditaNomeDisciplina.Text;
        p.Sigla = etrEditaSiglaDisciplina.Text;
        p.Obs = edtEitaDisciplinas.Text;

        await App.DbDisc.Update(p);
        await DisplayAlert("Sucesso", "Registro alterado.", "OK");
        await Navigation.PopAsync();
    }

    private void BtnCancelar_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}