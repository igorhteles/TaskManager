using TaskManager.Domain.Enums;

namespace TaskManager.Domain.Requests
{
    public class RequestTask
    {
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public  TaskPriority Priority { get; set; }
        public TaskPosition Position { get; set; }
        public DateTime DeadLine { get; set; }
    }
}
