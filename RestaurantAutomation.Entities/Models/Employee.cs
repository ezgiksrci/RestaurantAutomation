using RestaurantAutomation.Entities.Abstractions;

namespace RestaurantAutomation.Entities.Models
{
    public class Employee : Entity
    {
        public string? Name { get; set; }
        public string? Position { get; set; }
        public decimal Salary { get; set; }
    }
}
