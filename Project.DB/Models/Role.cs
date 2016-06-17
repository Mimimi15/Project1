using System;
using System.Collections.Generic;

namespace Project.DB.Models
{
    public partial class Role:BaseEntity
    {
        public Role()
        {
            this.UserInRoles = new List<UserInRole>();
        }

        public decimal RoleId { get; set; }
        public string Role1 { get; set; }
        public virtual ICollection<UserInRole> UserInRoles { get; set; }
    }
}
