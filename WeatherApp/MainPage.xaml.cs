﻿namespace WeatherApp;

public partial class MainPage : ContentPage
{
	Results resultado;
	const string Url="https://api.hgbrasil.com/weather?woeid=455963&Key=3c51ec7f";
	
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
		resultado.currently = "dia";
		resultado.cloudness = 11;
		resultado.city = "Itu, SP";
		resultado.temp = 23;
		resultado.description = "Tempo Nublado";
	}
	void FIllPage()
	{
		
		TempLabel.Text = resultado.temp.ToString();
		CityLabel.Text = resultado.city;
		DescriptionLabel.Text = resultado.description;


		if(resultado.currently == "dia")
		{
			if(resultado.rain >= 10)
			{
				BgImg.Source = "rainyday.png";
			}
			if (resultado.cloudness >= 10)
			{
				BgImg.Source = "cloudyday.png";
			}

		}
		
	}

	
}

