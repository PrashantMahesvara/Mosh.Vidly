using Mosh.Vidly.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mosh.Vidly.Dtos
{
    public class CustomerDto
    {
        [Id]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }


        public DateTime? Birthday { get; set; }
    }
}