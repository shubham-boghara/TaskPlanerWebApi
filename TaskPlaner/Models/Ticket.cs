using System;

namespace TaskPlaner.Models
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public string RefTickedId { get; set; }
        public int? ProjectId { get; set; }
        public string TicketName { get; set;}
        public string TicketDescription { get; set;}
        public DateTime? DueDate { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get;}
        public Project Project { get; set; }
    }
}
