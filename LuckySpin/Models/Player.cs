using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace LuckySpin.Models
{
    public class Player
    {

        public long Id { get; set; } //all Entity Models have an Id
        public String FirstName { get; set; }
        public ICollection<Spin> Spins { get; set; } 
        public int Luck { get; set; }
        public Decimal Balance { get; set; }

    }
}