using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Model.Models;

namespace WebAPI.Data
{
    public class WebAPIDbcontext : DbContext
    {
        public WebAPIDbcontext() : base("WebAPIConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
            //Khi load bang cha thi khong tu dong load bang con nua
        }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //ghi de 
        }
    }
}
