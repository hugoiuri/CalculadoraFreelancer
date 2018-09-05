using Microsoft.WindowsAzure.MobileServices;
using SQLite;
using System;

namespace CalculadoraFreelancer.Domain.Core.Models
{
    public class Entity
    {
        [PrimaryKey]
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Entity()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
