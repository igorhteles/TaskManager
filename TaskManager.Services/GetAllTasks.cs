using System;
using TaskManager.Domain.Enums;
using TaskManager.Domain.Responses;

namespace TaskManager.Services
{
    public class GetAllTasks
    {
        public ResponseAllTasks Execute()
        {
            return new ResponseAllTasks
            {
                Tasks = new List<ResponseViewTasks> {
                    new ResponseViewTasks {
                        Id = 0,
                        Name = "Academia",
                        Description = "Treino Semanal",
                        Priority = TaskPriority.Alta,
                        Position = TaskPosition.Aguardando,
                        DeadLine = DateTime.Now
                    },
                    new ResponseViewTasks {
                        Id = 1,
                        Name = "Dieta Treino",
                        Description = "Dieta para ganho de masa",
                        Priority = TaskPriority.Media,
                        Position = TaskPosition.EmAndamento,
                        DeadLine = DateTime.Now
                    },
                    new ResponseViewTasks {
                        Id = 2,
                        Name = "Leitura de Livro",
                        Description = "Livro sobre metabolismo",
                        Priority = TaskPriority.Baixa,
                        Position = TaskPosition.Concluida,
                        DeadLine = DateTime.Now
                    }
                }
            };
        }
    }
}
