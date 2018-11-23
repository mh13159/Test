using System;
using System.ComponentModel.DataAnnotations;

namespace EventManagmentFin.Models {
    public class Participant
     {
        public int ParticipantID { get; set; } //system generated
        [Required (ErrorMessage = "Please Enter Your Name")]
        public String ParticipantName { get; set; } // user entered
        public DateTime RegistrationDate { get; set; } // system generated

    }
}