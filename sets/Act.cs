using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGR.sets
{
    public class Headache
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public int Timecount { get; set; }
        public int goals { get; set; }
        public string? Description { get; set; }
        public string? Solution { get; set; }
    }
}
