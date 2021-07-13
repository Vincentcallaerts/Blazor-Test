using Microsoft.AspNetCore.Components;
using MyFirstBlazor.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstBlazor.Pages
{
    public class ForcastBase : ComponentBase
    {
        public WeatherForecast[] Forecasts;

        [Inject]
        protected WeatherForecastService WeatherForecastService { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Forecasts = await WeatherForecastService.GetForecastAsync(DateTime.Now);
        }
        
    }
}
