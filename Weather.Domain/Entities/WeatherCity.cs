﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.Domain.Entities
{
    public class WeatherCity : Base
    {        
        public string City { get; set; }
        public decimal Temp { get; set; }
        public decimal TempMin { get; set; }
        public decimal TempMax { get; set; }
        public DateTime Date { get; set; }
    }
}
