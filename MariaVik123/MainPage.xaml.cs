namespace MariaVik123;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	void iniciarjogoquandoclicado(object sender, EventArgs args) 
	{
		Application.Current.MainPage = new GamePage();
	}

	void Irparapreferenciasquandoclicado(object sender, EventArgs args)
	{
		Application.Current.MainPage = new preferenciaPage();
	}
	void irparasobrequandoclicado(object sender, EventArgs args)
	{
		Application.Current.MainPage = new sobrePage();
	}
}

