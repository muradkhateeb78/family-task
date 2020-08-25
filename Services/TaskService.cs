
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Core.Abstractions.Repositories;
using Core.Abstractions.Services;
using Domain.Commands;
using Domain.DataModels;
using Domain.Queries;

namespace Services
    {
    public class TaskService : ITaskService
        {
        private readonly ITaskRepository _taskRepository;
        private readonly IMapper _mapper;

        public TaskService (IMapper mapper, ITaskRepository taskRepository)
            {
            _mapper = mapper;
            _taskRepository = taskRepository;
            }

        public async Task<CreateTaskCommandResult> CreateTaskCommandHandler (CreateTaskCommand command)
            {
            var task = _mapper.Map<Domain.DataModels.Task>(command);
            var persistedTask = await _taskRepository.CreateRecordAsync(task);

            var t = _mapper.Map<Domain.DataModels.Task>(persistedTask);

            return new CreateTaskCommandResult()
                {
                Payload = t
                };

            }
        public async Task<UpdateTaskCommandResult> UpdateTaskCommandHandler (Guid id, UpdateTaskCommand command)
            {
            var isSucceed = true;
            var task = await _taskRepository.ByIdAsync(id);

            _mapper.Map<UpdateTaskCommand, Domain.DataModels.Task>(command, task);

            var affectedRecordsCount = await _taskRepository.UpdateRecordAsync(task);

            if ( affectedRecordsCount < 1 )
                isSucceed = false;

            return new UpdateTaskCommandResult()
                {
                Succeed = isSucceed
                };
            }

        public async Task<GetAllTasksQueryResult> GetAllTasksQueryHandler ()
            {
            IEnumerable<Domain.DataModels.Task> vm = new List<Domain.DataModels.Task>();

            var tasks = await _taskRepository.Reset().ToListAsync();

            if ( tasks != null && tasks.Any() )
                vm = _mapper.Map<IEnumerable<Domain.DataModels.Task>>(tasks);

            return new GetAllTasksQueryResult()
                {
                Payload = vm
                };
            }


        }
    }
