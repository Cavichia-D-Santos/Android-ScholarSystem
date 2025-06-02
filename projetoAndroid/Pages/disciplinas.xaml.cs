using projetoAndroid.Model;
using System.Collections.ObjectModel;

namespace projetoAndroid.Pages;

public partial class disciplinas : ContentPage
{
    ObservableCollection<Disciplina> lista = new ObservableCollection<Disciplina>();
	public disciplinas()
	{
		InitializeComponent();
        lstDisciplinas.ItemsSource = lista;
	}
    //NAVEGAÇÃO
    private async void PaginaAdicionaDisciplina_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new adicionarDisciplina());
    }

    //DADOS
    protected async override void OnAppearing()
    {
        List<Disciplina> tmp = await App.DbDisc.GetAll();
        lista.Clear();

        foreach (Disciplina disc in tmp)
        {
            lista.Add(disc);
        }
    }

    private void MenuAlterar_Clicked(object sender, EventArgs e)
    {
        MenuItem selecionado = sender as MenuItem;
        Disciplina p = selecionado.BindingContext as Disciplina;

        Navigation.PushAsync(new Views.editarDisciplina { BindingContext = p });
    }

    private async void MenuRemover_Clicked(object sender, EventArgs e)
    {
        MenuItem selecionado = sender as MenuItem;
        Disciplina p = selecionado.BindingContext as Disciplina;
        bool confirma = await DisplayAlert("ATENÇÃO", "Confirma a remoção?", "Sim", "Não");

        if (confirma == true)
        {
            await App.DbDisc.Delete(p.Id);
            lista.Remove(p);
            await DisplayAlert("REMOÇÃO", "Registro removido com sucesso.", "OK");
        }
    }

    private async void scbarDisciplina_TextChanged(object sender, TextChangedEventArgs e)
    {
        string q = e.NewTextValue;
        lista.Clear();

        List<Disciplina> tmp = await App.DbDisc.Search(q);

        foreach (Disciplina disc in tmp)
        {
            lista.Add(disc);
        }
    }
}