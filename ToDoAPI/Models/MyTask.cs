using System;
using System.Collections.Generic;

namespace ToDoAPI.Models
{
    public partial class MyTask
    {
        public int TaskId { get; set; }
        public string Description { get; set; }
        public int? TaskLog { get; set; }
        public int? Importance { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? CreateUser { get; set; }
        public int? Status { get; set; }
        public int? LastPerformer { get; set; }
        public int? Performer { get; set; }
        public DateTime? DeadLine { get; set; }
        public DateTime? CompleteTime { get; set; }
        public bool? IsComplete { get; set; }
        public int? Parrent { get; set; }
        public int? Project { get; set; }
        public string Marks { get; set; }
        public int? Category { get; set; }
    }
}
