namespace MariaVik123;

public partial class SegundaPage : ContentPage
{
public SegundaPage()
	{
		InitializeComponent();
	}

	void quandoclicarnobotaosim(object sender,EventArgs args)
	{
		//Application.Current.MainPage = new SegundaPage();
	}

	void quandoclicarnobotaonao(object sender,EventArgs args)
	{
		Application.Current.MainPage = new GameOverPage();
	}
}