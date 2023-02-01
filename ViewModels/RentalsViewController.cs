using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class RentalsViewController : Controller
    {
        public List<Rental> Rentals { get; set; }

        public RentalsViewController()
        {

        }
    }
}