using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.DataModels
    {
    [Table("Task")]
    public class Task
        {
        public Guid Id { get; set; } = Guid.NewGuid();
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
        [ForeignKey("Member")]
        public Guid? AssignedMemberId
            {
            get;
            set;
            }
        public Member AssignedMember
            {
            get;
            set;
            }
        }
    }
