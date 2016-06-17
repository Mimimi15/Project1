using System;
using System.Collections.Generic;

namespace Project.Models
{
    public partial class AspNetUser
    {
        public AspNetUser()
        {
            this.AspNetUserClaims = new List<AspNetUserClaim>();
            this.AspNetUserLogins = new List<AspNetUserLogin>();
            this.Records = new List<Record>();
            this.Records1 = new List<Record>();
            this.AspNetRoles = new List<AspNetRole>();
        }

        public string Id { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string Discriminator { get; set; }
        public virtual ICollection<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual ICollection<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual ICollection<Record> Records { get; set; }
        public virtual ICollection<Record> Records1 { get; set; }
        public virtual ICollection<AspNetRole> AspNetRoles { get; set; }
    }
}
