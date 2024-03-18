namespace MariaVik123;

public partial class preferenciaPage : ContentPage
{

	public preferenciaPage()
	{
	    InitializeComponent();
	}
	

    void buttonvoltar(object sender, EventArgs args)
	{
		Application.Current.MainPage = new MainPage();
    }    
}