﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieCustomerMVCWithAuthentication.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
    }
}