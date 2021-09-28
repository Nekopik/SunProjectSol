using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunProject.Models
{
    public class CalculatorEnergy
    {
        [Required(ErrorMessage = "Please enter your insolation level")]
        public float Insolation { get; set; } //naslonecznienie

        [Required(ErrorMessage = "Please enter your slope factor")]
        public float WspKor { get; set; } //wspolczynnik korekcyjny

        [Required(ErrorMessage = "Please enter your modules' power")]
        public float Power { get; set; } //moc modulow

        [Required(ErrorMessage = "Please enter your wspolczynnik wydajnosci")]
        public float WW { get; set; } //wspolczynnik wydajnosci

        [Required(ErrorMessage = "Please enter your natezenie promieniowania")]
        public float NatProm { get; set; } //natezenie promieniowania
    }
}
