using System;
using Core.Enums;

namespace Core.Models.EfModels
{
    public class TodoItem
    {
        public int Id { get; set; }
        public DateTime? DoneOn { get; set; }
        public DateTime? Deadline { get; set; }
        public bool Recurring { get; set; }
        public string Description { get; set; }
        public TodoType TodoType { get; set; }
    }
}
