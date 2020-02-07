using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nick_the_Dev.Data.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public Category Category { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public DateTime? ReleaseDate { get; set; }
        
    }
}
