using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ADO.Net_L1.Models {
    //FrontEnd Model
    public class CarModel {
        [Display(Name = "Registration Number")]
        [Required(ErrorMessage = "Registration Number cannot be empty")]
        public string RegistrationNumber { get; set; }
        [Display(Name = "Car Type")]
        [Required(ErrorMessage = "Car Type cannot be empty")]
        public string CarType { get; set; }

    }
}