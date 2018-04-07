using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MoviesClub.Models;

namespace MoviesClub.ViewModels
{
    public class MovieCustomerViewModels
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}