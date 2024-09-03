using TaskManager.Domain.Enums;
using TaskManager.Domain.Requests;
using TaskManager.Domain.Responses;

namespace TaskManager.Services
{
    public class UpdateTasks
    {
        public ResponseViewTasks Execute (int id, RequestTask request) {
            return new ResponseViewTasks
            {
                Id = id,
                Name = request.Name,
                Description = request.Description,
                Priority = request.Priority,
                Position = request.Position,
                DeadLine = request.DeadLine
            };
        }   
    }
}