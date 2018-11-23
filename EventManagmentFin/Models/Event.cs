using System;
using System.ComponentModel.DataAnnotations;

namespace EventManagmentFin.Models {
    public class Event {

        public int EventId { get; set; } //self generated

       [Required (ErrorMessage = "Event type Required")]
//[Required]
        public string EventHead { get; set ;}
        public string Type { get; set; } //user added

        [Required (ErrorMessage = "Event Name Required")]
       // [Required]
        public string EventName { get; set; } //user added

       [Required (ErrorMessage = "Please add an Expected/exact Event Date")]
     //  [Required]
        public DateTime Date { get; set; } //user added

        public string Status { get; set; } // auto filled

        public string EventDescription { get; set; } //What is this event About

    }
}