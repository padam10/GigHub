using System.Collections.Generic;

namespace Gighub.ViewModels
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using Gighub.Models;

    public class GigFormViewModel
    {
        [Required]
        public string Venue { get; set; }
        [Required]
        [FutureDate]
        public string Date { get; set; }
        [Required]
        [ValidTime]
        public string Time { get; set; }
        [Required]
        public int Genre { get; set; }
  
        public IEnumerable<Genre> Genres { get; set; }

        public DateTime GetDateTime()
        {
               return Convert.ToDateTime(this.Date + " " + this.Time);
            
        }
        
    }
}