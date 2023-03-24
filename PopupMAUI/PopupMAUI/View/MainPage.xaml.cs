namespace PopupMAUI;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}
	
	private void OpenButton_Clicked(object sender, EventArgs e)
	{
		sfPopup.Show();
	}
}

