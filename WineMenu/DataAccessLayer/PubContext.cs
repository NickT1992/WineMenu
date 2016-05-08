using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WineMenu.Models;
using System.Data.Entity;

namespace WineMenu.DataAccessLayer
{
    public class PubContext : DbContext
    {
        public DbSet<Pub> JHPubs { get; set; }


    }
}