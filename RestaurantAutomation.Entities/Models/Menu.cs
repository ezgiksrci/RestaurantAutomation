using RestaurantAutomation.Entities.Abstractions;

namespace RestaurantAutomation.Entities.Models
{
    public class Menu : Entity
    {
        public string Name { get; set; }
        public virtual ICollection<MenuItem> MenuItems { get; set; }
    }
}
