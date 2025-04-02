namespace projetoAndroid.Pages;

public partial class sobrePage : ContentPage
{
	public sobrePage()
	{
		InitializeComponent();
	}
    private void OnTappedAbrirGithub(object sender, TappedEventArgs e)
    {
        var url = "https://github.com/Cavichia-D-Santos";
        Launcher.OpenAsync(url);
    }

    private void OnTappedAbrirLinkedin(object sender, TappedEventArgs e)
    {
        var url = "https://www.linkedin.com/in/thiago-cavichia/";
        Launcher.OpenAsync(url);
    }

}