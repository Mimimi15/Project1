using System;
using System.Collections.Generic;

namespace Project.DB.Models
{
    public partial class UserInRole: BaseEntity
    {
        public decimal Id { get; set; }
        public decimal UserId { get; set; }
        public decimal RoleId { get; set; }
        public virtual Role Role { get; set; }
        public virtual User User { get; set; }
    }
}
