using System;
using TaskManager.Domain.Enums;

namespace TaskManager.Domain.Responses
{
    public class ResponseViewTasks
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public  TaskPriority Priority { get; set; }
        public TaskPosition Position { get; set; }
        public DateTime DeadLine { get; set; }
    }
}
