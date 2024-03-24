﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GigHub.Models;

namespace GigHub.ViewModels
{
    public class GigFormViewModel
    {
        [Required]
        public string Venue { get; set; }

        [Required]
        [FutureDate]
        public string Date { get; set; }

        [Required]
        public string Time { get; set; }

        public DateTime GetDateTime() => DateTime.Parse(string.Format("{0} {1}", Date, Time));

        [Required]
        public byte Genre { get; set; }

        public IEnumerable<Genre> Genres { get; set; }
    }
}