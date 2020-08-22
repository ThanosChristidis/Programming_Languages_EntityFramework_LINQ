using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming_Languages.Entities;
using System.Data.Entity;

namespace Programming_Languages.Database
{
    public class ProgrammingLanguagesDatabase:DbContext
    {
        public ProgrammingLanguagesDatabase() : base("connection") { }

        public DbSet<ProgrammingLanguage> ProgrammingLanguages { get; set; }
       
    }
}
