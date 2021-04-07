using System;
using System.Windows;
using WeatherService_Serv;

namespace weatherWPF
{
    public partial class MainWindow : Window
    {
        private GetWeatherService _weatherService;
        public MainWindow()
        {
            InitializeComponent();
            _weatherService = new GetWeatherService();
        }

        private void GetWeather(object sender, RoutedEventArgs e)
        {
            var weather = _weatherService.GetWeather(cityTxtBox.Text);
            if (weather == null)
            {
                cityTxtBox.Text = "Такого города не существует";
            }
            else
            {
                weather.main.ConventToCelsius();
                this.DataContext = weather;
                weatherPanel.Visibility = Visibility.Visible;
            }
        }
    }
}