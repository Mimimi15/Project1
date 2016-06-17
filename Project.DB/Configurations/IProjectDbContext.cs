using System;
using System.Data.Entity;
using Project.DB.Models;

namespace Project.DB.Configurations
{
    public interface IProjectDbContext : IDisposable
    {
        IDbSet<AspNetRole> AspNetRoles { get; set; }
        IDbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        IDbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        IDbSet<AspNetUser> AspNetUsers { get; set; }
        IDbSet<Record> Records { get; set; }
    }
}
