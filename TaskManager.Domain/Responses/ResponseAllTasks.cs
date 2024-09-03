namespace TaskManager.Domain.Responses
{
    public class ResponseAllTasks
    {
        public List<ResponseViewTasks> Tasks { get; set; } = new();
    }
}
