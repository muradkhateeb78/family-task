using System;
using AutoMapper;
using Domain.Commands;
using Domain.DataModels;

namespace WebApi.AutoMapper
    {
    public class TaskProfile : Profile
        {
        public TaskProfile ()
            {
            CreateMap<CreateTaskCommand, Task>();
            CreateMap<UpdateTaskCommand, Task>();
            }
        }
    }
