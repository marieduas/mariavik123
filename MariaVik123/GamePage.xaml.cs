namespace MariaVik123;

public partial class GamePage : ContentPage
{
	public GamePage()
	{
		InitializeComponent();
	}

	void quandoclicarnobotaosim(object sender,EventArgs args)
	{
		Application.Current.MainPage = new SegundaPage();
	}

	void quandoclicarnobotaonao(object sender,EventArgs args)
	{
		Application.Current.MainPage = new GameOverPage();
	}
}