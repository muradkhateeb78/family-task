﻿using System;
using System.Collections.Generic;
using System.Text;
using Domain.DataModels;

namespace Core.Abstractions.Repositories
    {
    public interface ITaskRepository : IBaseRepository<Guid, Task, ITaskRepository>
        {
        }
    }
