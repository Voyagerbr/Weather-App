namespace WeatherApp;

public partial class MainPage : ContentPage
{
	Results resultado;

	public MainPage()
	{
		
		InitializeComponent();
		resultado = new Results();
	
		Testing();	
		FIllPage();
	}
	void Testing(){
		resultado = new Results();
		resultado.rain = 10;
	}
	void FIllPage()
	{
		RainLabel.Text = resultado.rain.ToString();
		
	}

	
}

