﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThemeParkTycoonGame
{
    public class Weather
    {
        public static Weather[] WeatherTypes;
        private static Random numberGenerator;

        public string Name { get; set; }
        public Image Image { get; set; }

        public Weather(string name, Image image)
        {
            Name = name;
            Image = image;
        }

        private static void CreateWeatherTypesIfNotExists()
        {
            numberGenerator = new Random();

            WeatherTypes = new Weather[]
            {
                new Weather("Sunny", Properties.Resources.weather_sun_48),
                new Weather("Rainy", Properties.Resources.weather_rain_48),
                new Weather("Stormy", Properties.Resources.weather_storm_48),
                new Weather("Snow", Properties.Resources.weather_snow_48),
            };
        }

        public static Weather GetRandom()
        {
            CreateWeatherTypesIfNotExists();

            return WeatherTypes[numberGenerator.Next(0, WeatherTypes.Length)];
        }
    }
}
