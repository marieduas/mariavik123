namespace MariaVik123;

public partial class GameOverPage : ContentPage
{
    public GameOverPage()
	{
		InitializeComponent();
	}

	void quandoclicarnobotaovoltar(object sender,EventArgs args)
	{
		Application.Current.MainPage = new MainPage();
	}

}