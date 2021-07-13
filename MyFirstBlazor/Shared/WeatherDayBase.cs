using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstBlazor.Shared
{
    public class WeatherDayBase : ComponentBase        
    {
        [Parameter]
        public DayOfWeek DayOfWeek { get; set; }
        [Parameter]
        public int Temperature { get; set; }
        [Parameter]
        public string Summary { get; set; }

        protected string Icon => Summary == "Cloudy" ? "cloud" : Summary == "Rainy" ? "rain" : "sun";
    }
}
