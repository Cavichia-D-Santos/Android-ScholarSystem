using projetoAndroid.Model;
using System.Collections.ObjectModel;
//using projetoAndroid.Views;

namespace projetoAndroid.Pages
{
	public partial class periodos : ContentPage
	{
		ObservableCollection<Periodo> lista = new ObservableCollection<Periodo>();
		public periodos()
		{
			InitializeComponent();
			lstPeriodos.ItemsSource = lista;
		}
		//NAVEGAÇÃO
		private async void PaginaAdicionarPeriodo_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new adicionarPeriodo());
		}

		private async void PaginaEditarPeriodo_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new editarPeriodo());
		}
		//DADOS
		protected async override void OnAppearing()
		{
			List<Periodo> tmp = await App.Db.GetAll();
			lista.Clear();

			foreach(Periodo periodo in tmp)
			{
				lista.Add(periodo);
			}
		}

		private async void MenuAlterar_Clicked(object sender, EventArgs e)
		{
			//Periodo p = new Periodo();
		}

		private async void MenuRemover_Clicked(object sender, EventArgs e)
		{
			var botao = sender as ImageButton;
			var selecionaPeriodo = botao.BindingContext as Periodo;

			if(selecionaPeriodo != null)
			{
				bool confirma = await DisplayAlert("ATENÇÃO", "Confirma a remoção?", "Sim", "Não");

				if(confirma == true)
				{
					await App.Db.Delete(selecionaPeriodo.Id);
					lista.Remove(selecionaPeriodo);
				}
			}
		}

		private async void scbarPeriodo_TextChanged(object sender, TextChangedEventArgs e)
		{
			string q = e.NewTextValue;
			lista.Clear();

			List<Periodo> tmp = await App.Db.Search(q);

			foreach(Periodo periodo in tmp)
			{
				lista.Add(periodo);
			}
		}
	}
}