using System;
using TaskManager.Domain.Enums;

namespace TaskManager.Domain.Responses
{
    public class ResponseTask
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
    }
}
