using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class NewRentalDTO
    {
        [Required]
        public int CustomerId { get; set; }

        [Required]
        public List<int> MovieIds { get; set; }
    }
}