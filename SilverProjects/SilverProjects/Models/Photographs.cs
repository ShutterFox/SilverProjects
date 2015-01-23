using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SilverProjects.Models

{
    public class Photographs
    {
        public int ID { get; set; }
        public HtmlString filepath { get; set; }
        public string tags { get; set; }
        public string category { get; set; }
        
    }

    public class PhotographsDBContext : DbContext
    {
        public DbSet<Photographs> Photographs { get; set; }
    }
}
