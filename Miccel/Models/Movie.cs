using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Miccel.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Movie> Movies { get; set; }
        
    }
    //movie/random
}