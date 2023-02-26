using System;
using System.Collections.Generic;

namespace TaskPlaner.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string RefProjectId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public ICollection<Ticket> Tickets { get; set; }

    }
}
