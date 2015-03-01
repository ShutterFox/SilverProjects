using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SilverProjects.Models
{
    public class Photos
    {
        public int ID { get; set; }
        public string FileName { get; set; }
        public string Tags { get; set; }
        public String Category { get; set; }

    }

    public class PhotosDBContext : DbContext
    {
        public DbSet<Photos> Photos { get; set; }
    }
}