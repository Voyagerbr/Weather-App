﻿using System.Text.Json;
using System.Text.Json.Serialization;

namespace WeatherApp;

public partial class MainPage : ContentPage
{
	Results results;
	Resposta resposta;
	
	const string Url="https://api.hgbrasil.com/weather?woeid=427271&key=3c51ec7f";
	
	public MainPage()
	{
		
		InitializeComponent();
		ActualTime();	
		
	}
	
	async void ActualTime()
	{
		try{
			var httpClient = new HttpClient();
			var response = await httpClient.GetAsync(Url);

			if(response.IsSuccessStatusCode)
			{
				string content = await response.Content.ReadAsStringAsync();
				resposta = JsonSerializer.Deserialize<Resposta>(content);
				FIllPage();
			}
	}	
		catch(Exception e)
		{
			System.Diagnostics.Debug.WriteLine(e);
		}
	}

	void FIllPage()
	{
		
		TempLabel.Text = resposta.results.temp.ToString();
		CityLabel.Text = resposta.results.city;
		DescriptionLabel.Text = resposta.results.description;
		RainLabel.Text = resposta.results.rain.ToString();
		HumidityLabel.Text = resposta.results.humidity.ToString();
		WindSpeedyLabel.Text = resposta.results.wind_speedy;
		WindCardinalLabel.Text = resposta.results.wind_cardinal;
		SunriseLabel.Text = resposta.results.sunrise;
		SunsetLabel.Text = resposta.results.sunset;
		MoonPhaseLabel.Text = resposta.results.moon_phase;
		ForecastList.ItemsSource = resposta.results.forecast;
		


		if (resposta.results.currently == "dia")
		{
			if(resposta.results.description == "Chuva")
			{
				BgImg.Source = "rainyday.png";
			}
			else if (resposta.results.description == "Tempo nublado")
			{
				BgImg.Source = "cloudyday.png";
			}
			else 
			{
				BgImg.Source = "cleanday.png";
			}
		}
		else
		{
			if(resposta.results.description == "Chuva")
			{
				BgImg.Source = "rainynight.png";

				
			}

			else if (resposta.results.description == "Tempo nublado")
			{
				BgImg.Source = "cloudynight.png";
			}
			else 
			{
				BgImg.Source = "cleannight.png";
			}

		}
			if (resposta.results.moon_phase == "new")
			{
				MoonPhaseLabel.Text = "Nova";
			}

			else if (resposta.results.moon_phase == "waxing_crescent")
			{
				MoonPhaseLabel.Text = "Crescente";
			}
			else if (resposta.results.moon_phase == "first_quarter")
			{
				MoonPhaseLabel.Text = "Crescente";
			}
		
	}

	
}

