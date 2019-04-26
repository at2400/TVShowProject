using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace TVShowProject.Models
{
    public class ShowCast
    {
        public int ShowID {get; set;}
        public int MemberID {get; set;}
        public Show Shows {get; set;}
        public Cast Cast {get; set;}
    }
}