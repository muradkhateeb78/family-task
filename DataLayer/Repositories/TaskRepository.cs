﻿using System;
using Core.Abstractions.Repositories;
using Domain.DataModels;

namespace DataLayer.Repositories
    {
    public class TaskRepository : BaseRepository<Guid, Task, TaskRepository>, ITaskRepository
        {
        public TaskRepository (FamilyTaskContext context) : base(context)
            {
            }

        ITaskRepository IBaseRepository<Guid, Task, ITaskRepository>.NoTrack ()
            {
            return base.NoTrack();
            }

        ITaskRepository IBaseRepository<Guid, Task, ITaskRepository>.Reset ()
            {
            return base.Reset();
            }
        }
    }
