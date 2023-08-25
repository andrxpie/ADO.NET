﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF___Airlines__hw_
{
    public class Airplanes
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Model { get; set; }

        [ForeignKey ("Type")]
        public int TypeId { get; set; }
        public AType Type { get; set; }

        [ForeignKey ("Country")]
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public ICollection<Flights> Flights { get; set; }
    }
}