﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify_Premium_Lite
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Artist> Artists { get; set; }
    }
}