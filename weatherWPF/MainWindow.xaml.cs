using System;
using System.Linq;
using System.Windows;
using WeatherService_Serv;

namespace weatherWPF
{
    public partial class MainWindow : Window
    {
        private GetWeatherService _weatherService;
        private ApplicationContext _applicationContext;
        private Root _root;
        public MainWindow()
        {
            InitializeComponent();
            _weatherService = new GetWeatherService();
            _applicationContext = new ApplicationContext();
            _root = new Root();
        }

        private void GetWeather(object sender, RoutedEventArgs e)
        {
            _root = _weatherService.GetWeather(cityTxtBox.Text);
            if (_root == null)
            {
                cityTxtBox.Text = "Такого города не существует";
            }
            else
            {
                _root.main.ConventToCelsius();
                this.DataContext = _root;
                weatherPanel.Visibility = Visibility.Visible;
                btnDB.Visibility = Visibility.Visible;
            }
        }

        private void SaveToDatabase(object sender, RoutedEventArgs e)
        {
            var weather = new weatherDataBase
            {
                temp = _root.main.temp,
                feels_like = _root.main.feels_like,
                temp_min = _root.main.temp_min,
                temp_max = _root.main.temp_max,
                speed = _root.wind.speed,
                deg = _root.wind.deg,
                name = _root.name,
                main = _root.weather.First().main,
                description = _root.weather.First().description
            };
            _applicationContext.weatherDataBases.Add(weather);
            _applicationContext.SaveChanges();
        }

        private void showDataBase(object sender, RoutedEventArgs e)
        {
            lstDB.ItemsSource = _applicationContext.weatherDataBases.AsEnumerable().ToList();
        }
    }
}