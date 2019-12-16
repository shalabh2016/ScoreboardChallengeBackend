using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ScoreboardChallenge.Model
{
    public class PlayerPointModel
    {
        [Key]
        public int PlayerPointId { get; set; }
        public string PlayerName {get;set;}   
        public int Points {get;set;}
    }
}
