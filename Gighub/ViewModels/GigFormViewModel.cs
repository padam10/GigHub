using System.Collections.Generic;

namespace Gighub.ViewModels
{
    using System;

    using Gighub.Models;

    public class GigFormViewModel
    {
        public string Venue { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }

        public int Genre { get; set; }

        public IEnumerable<Genre> Genres { get; set; }

        public DateTime DateTime => Convert.ToDateTime(this.Date + " " + this.Time);
    }
}