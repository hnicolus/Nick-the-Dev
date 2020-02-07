using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nick_the_Dev.Data.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Project> Projects { get; set; }
    }
}
