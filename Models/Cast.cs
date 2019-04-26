using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace TVShowProject.Models
{
    public class Cast
    {
        public int MemberID {get; set;}
        public string Name {get; set;}
        public List<ShowCast> ShowCast {get; set;}

    }
}