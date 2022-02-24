using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Ehrman_SD2.Models;

namespace Ehrman_SD2.DAL
{
    public class Ehrman_SD2Context : DbContext 
    {
        public Ehrman_SD2Context() : base ("DefaultConnection")
        {

        }
        public DbSet<Pet> pets { get; set; }
        public DbSet<Visit> visits { get; set; }
        public DbSet<Vet> vets { get; set; }

        public System.Data.Entity.DbSet<Ehrman_SD2.Models.User> Users { get; set; }
    }
}