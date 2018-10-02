using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MedConsult.Models.Common
{
    public class Entity
    {
        [Key]
        public Guid Id { get; set; }

        public DateTime CreationDate { get; set; }
    }
}
