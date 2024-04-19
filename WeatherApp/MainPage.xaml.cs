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
		resultado.Rain = 10;
		resultado.Currently = "dia";
		resultado.Cloudness = 11;
	}
	void FIllPage()
	{
		
		RainLabel.Text = resultado.Rain.ToString();

		if(resultado.Currently == "dia")
		{
			if(resultado.Rain >= 10)
			{
				BgImg.Source = "rainyday.png";
			}
			if (resultado.Cloudness >= 10)
			{
				BgImg.Source = "cloudyday.png";
			}

		}
		
	}

	
}

