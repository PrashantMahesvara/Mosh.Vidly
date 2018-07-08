﻿using System.ComponentModel.DataAnnotations;

namespace Mosh.Vidly.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
    }
}