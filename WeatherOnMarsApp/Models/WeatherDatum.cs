using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WeatherOnMarsApp.Models;

public partial class WeatherDatum
{
    public int Id { get; set; }



    [Display(Name = "Data ziemska")]
    public DateTime? TerrestrialDate { get; set; }


    [Display(Name = "Temperatura minimalna")]
    public double MinTemp { get; set; }


    [Display(Name = "Temperatura maksymalna")]
    public double MaxTemp { get; set; }


    [Display(Name = "Prędkość wiatru")]
    [Range(0, double.MaxValue, ErrorMessage = "WindSpeed must be a non-negative number.")]
    public double? WindSpeed { get; set; }


    [Display(Name = "Ciśnienie")]
    [Range(0, double.MaxValue, ErrorMessage = "Pressure must be a non-negative number.")]
    public double Pressure { get; set; }
    [Display(Name = "Warunki pogodowe")]


    public string? AtmoOpacity { get; set; }
}
