﻿using Microsoft.WindowsAzure.MobileServices;
using System;

namespace CalculadoraFreelancer.Domain.Core.Models
{
    public class Entity
    {
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        [Version]
        public string Version { get; set; }
    }
}
