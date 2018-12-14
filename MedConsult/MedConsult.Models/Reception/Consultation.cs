using MedConsult.Models.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedConsult.Models.Reception
{
    public class Consultation : Entity
    {
        public DateTime DateOfConsultation { get; set; }
        public DateTime TimeFrom { get; set; }
        public DateTime TimeTo { get; set; }

        public Guid Doctor { get; set; }
        public bool IsAccepted { get; set; }
        public Guid Patient { get; set; }
        public int Duration { get; set; }

        public string Notes { get; set; }

    }
}
