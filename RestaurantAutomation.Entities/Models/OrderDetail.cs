using RestaurantAutomation.Entities.Abstractions;

namespace RestaurantAutomation.Entities.Models
{
    public class OrderDetail : Entity
    {
        public Guid OrderID { get; set; }
        public virtual Order? Order { get; set; }
        public Guid MenuItemID { get; set; }
        public virtual MenuItem? MenuItem { get; set; }
        public int Quantity { get; set; }
    }
}
