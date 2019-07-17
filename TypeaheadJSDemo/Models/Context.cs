using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TypeaheadJSDemo.Models
{
    public class Context:DbContext
    {
        public Context() : base("StringDBContext") { }
        public DbSet<Angular> TypeAheads { get; set; }
    }
}