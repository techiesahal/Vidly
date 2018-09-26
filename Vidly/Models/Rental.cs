﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Rental
    {
        public int Id { get; set; }

        public DateTime DateRented { get; set; }

        public DateTime? DateReturned { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public int MovieId { get; set; }
        public IEnumerable<Movie> Movies { get; set; }
    }
}