using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManager.Domain.Enums;
using TaskManager.Domain.Responses;

namespace TaskManager.Services
{
    public class GetByIdTasks
    {
        public ResponseViewTasks Execute(int id)
        {
            return new ResponseViewTasks
            {
                Id = 0,
                Name = "Academia",
                Description = "Treino Semanal",
                Priority = TaskPriority.Alta,
                Position = TaskPosition.Aguardando,
                DeadLine = DateTime.Now
            };
        }
    }
}