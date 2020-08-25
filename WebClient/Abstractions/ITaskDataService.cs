using Domain.Commands;
using Domain.Queries;
using System;
using System.Threading.Tasks;

namespace WebClient.Abstractions
{
    public interface ITaskDataService
    {
        public Task<CreateTaskCommandResult> Create(CreateTaskCommand command);
        public Task<UpdateTaskCommandResult> Update(Guid id, UpdateTaskCommand command);
        public Task<GetAllTasksQueryResult> GetAllTasks();
    }
}
