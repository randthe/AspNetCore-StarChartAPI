﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StarChart.Models
{
    public class CelestialObject
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int? OrbitObjectId { get; set; }

        [NotMapped]
        public List<CelestialObject> Satalites { get; set; }

        public TimeSpan OrbitalPeriod { get; set; }

    }
}
