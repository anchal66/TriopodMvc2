using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Triopod.Models
{
    public class DataContext: DbContext
    {
        public DbSet<Enquiry> Enquiries { get; set; }
    }
}