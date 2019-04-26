using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace TVShowProject.Models
{
    public class Show
    {
        public int ShowID {get; set;}
        public string Title {get; set;}

        public int ReleaseDate {get; set;}
        public string Genre {get; set;}
        public List<ShowCast> ShowCast {get; set;}


    }
}