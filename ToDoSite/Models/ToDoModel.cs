using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoSite.Models
{
    public class ToDoModel
    {
        public string Title { get; set; }
        [DisplayName("From Date")]
        public DateTime FromDate { get; set; }
        [DisplayName("Done Date")]
        public DateTime? DoneDate { get; set; }
        [DisplayName("To Date")]
        public DateTime? ToDate { get; set; }
        public bool IsDone { get => DoneDate != null; }
    }
}
