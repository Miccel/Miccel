using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Miccel.Models;

namespace Miccel.ViewModels
{
    public class RandomMoviesViewModel
    {
        public List<Movie> Movies{ get; set; }
        public List<Customer> Customers{ get; set; }
    }
}