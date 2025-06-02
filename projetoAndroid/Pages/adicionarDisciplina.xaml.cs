using projetoAndroid.Model;

namespace projetoAndroid.Pages;

public partial class adicionarDisciplina : ContentPage
{
	public adicionarDisciplina()
	{
		InitializeComponent();
	}
    private async void BtnInserir_Clicked(object sender, EventArgs e)
    {
        Disciplina p = new Disciplina();
        p.Nome = etrNomeDisciplina.Text;
        p.Sigla = etrSiglaDisciplina.Text;
        p.Obs = edtObs.Text;

        await App.DbDisc.Insert(p);
        await DisplayAlert("SUCESSO", "Registro inserido", "OK");
        await Navigation.PopAsync();
    }

    private void BtnCancelar_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}