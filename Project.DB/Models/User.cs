using System;
using System.Collections.Generic;

namespace Project.DB.Models
{
    public partial class User:BaseEntity
    {
        public User()
        {
            this.Records = new List<Record>();
            this.Records1 = new List<Record>();
            this.UserInRoles = new List<UserInRole>();
        }

        public decimal UserId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public virtual ICollection<Record> Records { get; set; }
        public virtual ICollection<Record> Records1 { get; set; }
        public virtual ICollection<UserInRole> UserInRoles { get; set; }
    }
}
