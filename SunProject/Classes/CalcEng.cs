using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunProject.Classes
{
    public class CalcEng
    {
        [Required(ErrorMessage = "Please enter your insolation level")]
        public float Insolation { get; set; }

        [Required(ErrorMessage = "Please enter your slope factor")]
        public float WspKor { get; set; }

        [Required(ErrorMessage = "Please enter your modules' power")]
        public float Power { get; set; }

        [Required(ErrorMessage = "Please enter your wspolczynnik wydajnosci")]
        public float WW { get; set; }

        [Required(ErrorMessage = "Please enter your natezenie promieniowania")]
        public float NatPRom { get; set; }
    }
}
