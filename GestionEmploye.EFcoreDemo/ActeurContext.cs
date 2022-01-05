using Microsoft.EntityFrameworkCore;
using System;

namespace GestionEmploye.EFcoreDemo
{
    public class ActeurContext : DbContext
    {
       public DbSet<Acteurs> Acteurs { get; set; }
        public DbSet<Citations> Citations { get; set; }
    }
}
