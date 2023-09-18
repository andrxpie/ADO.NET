﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Data_Annotations
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<City> Cities { get; set; }
    }
}