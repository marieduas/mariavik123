namespace MariaVik123;

public partial class quartaPage : ContentPage
{
    public quartaPage()
{
    {
        InitializeComponent();
    }
}

    void quandoclicarnobotaovoltar(object sender,EventArgs args)
	{
		Application.Current.MainPage = new MainPage();
	}

    void quandoclicarnobotaonao(object senter,EventArgs args)
    {
        Application.Current.MainPage = new MainPage();
    }

    void quandoclicarnobotaosim(object sender,EventArgs args)
    {
        Application.Current.MainPage = new quintaPage();
    }


}