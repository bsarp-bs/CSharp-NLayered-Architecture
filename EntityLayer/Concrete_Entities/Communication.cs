using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Concrete_Entities
{
    public class Communication
    {
        public int CommunicationID { get; set; }
        public string? Name { get; set; }
        public string? Mail { get; set; }
        public string? Comment { get; set; }
        public DateTime? Date { get; set; }

    }
}
