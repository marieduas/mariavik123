namespace MariaVik123;

public partial class sobrePage : ContentPage
{
public sobrePage()
	{
		InitializeComponent();
	}

    void buttonvoltar(object sender, EventArgs args)
	{
		Application.Current.MainPage = new MainPage();
}
}