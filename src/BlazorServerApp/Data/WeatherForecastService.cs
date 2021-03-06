﻿using System;
using System.Linq;
using System.Threading.Tasks;

namespace Devpro.BlazorSamples.BlazorServerApp.Data
{
    public class WeatherForecastService
    {
        private static readonly string[] s_summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = s_summaries[rng.Next(s_summaries.Length)]
            }).ToArray());
        }
    }
}
