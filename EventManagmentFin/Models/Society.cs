using System.Collections.Generic;

namespace EventManagmentFin.Models {
    public class Society {
        public string ID {get;set;}
        public string PatronName { get; set; } // Patron of Society

        public string Name { get; set; } // Name of Society

        public string Location { get; set; } //patron room

        public string PageUrl { get; set; } //facebook or website
        public string Description { get; set; }

        public virtual ICollection<Event> Events { get; set; } // Society  0----->n events

        public virtual ICollection<Department> Departments { get; set; } // society 1...>n departments

        
        public virtual ICollection<Member> Members { get; set; } // Society 0 ---->n  members

        //Hierarchy
        public string Manager { get; set; }
        public string AssistantManger { get; set; }
        public string CFO { get; set; }
        //public string Page {get;set;}

    }
}