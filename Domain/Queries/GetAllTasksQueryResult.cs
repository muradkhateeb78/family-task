using System;
using System.Collections.Generic;
using System.Text;
using Domain.DataModels;

namespace Domain.Queries
    {
    public class GetAllTasksQueryResult
        {
        public IEnumerable<Task> Payload
            {
            get; set;
            }
        }
    }
