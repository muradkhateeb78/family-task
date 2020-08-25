using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Domain.DataModels;

namespace Domain.Commands
    {
    public class CreateTaskCommand
        {
        [Required]
        [MaxLength(256)]
        public string Subject
            {
            get;
            set;
            }
        [Required]
        public bool IsComplete
            {
            get;
            set;
            }
        public Guid? AssignedMemberId
            {
            get;
            set;
            }
        }
    }
