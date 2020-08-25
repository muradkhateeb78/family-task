using System;
using System.Collections.Generic;
using System.Text;
using Domain.DataModels;

namespace Domain.Commands
    {
    public class CreateTaskCommandResult
        {
        public Task Payload
            {
            get; set;
            }
        }
    }
