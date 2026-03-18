using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Concrete_Entities
{
    public class Journal
    {
        public int JournalID { get; set; }
        public string? Title { get; set; }
        public string? Desc { get; set; }
        public DateTime? Date { get; set; }
        public bool? Status { get; set; }

    }

}
