﻿using BookService.App.Middleware;
using ServiceStack.FluentValidation.Attributes;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BookService.App.Data
{
    [Validator(typeof(BookValidation))]
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }
    }
}
