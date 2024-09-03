using TaskManager.Domain.Requests;
using TaskManager.Domain.Responses;

namespace TaskManager.Services
{
    public class RegisterTask
    {
        public ResponseTask Execute(RequestTask request)
        {
            return new ResponseTask
            {
                Id = 8, 
                Name = request.Name
            };
        }
    }
}