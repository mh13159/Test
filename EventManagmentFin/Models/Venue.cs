using System;
using System.ComponentModel.DataAnnotations;

namespace EventManagmentFin.Models {
    public class Venue {

        public int ID { get; set; } //Self Genereate

        [Required (ErrorMessage = "VenueName Required")] //User Added
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required (ErrorMessage = "VenueCost Required")]
        public int Cost { get; set; }

        public String Createdby { get; set; }

        public DateTime Createdate { get; set; }

    }

}