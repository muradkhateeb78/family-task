using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.DataModels
{
    [Table("Member")]
    public class Member
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        [MaxLength(10)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(10)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(30)]
        public string Email { get; set; }
        [MaxLength(15)]
        public string Roles { get; set; }
        [MaxLength(10)]
        public string Avatar { get; set; }
    }
}
