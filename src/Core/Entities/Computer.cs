using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class Computer : BaseEntity
    {
        public string Hostname { get; set; }
        public int LabId { get; set; }
        public Lab Lab { get; set; }
    }
}
