﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_API_using_asp.net_web_application.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}