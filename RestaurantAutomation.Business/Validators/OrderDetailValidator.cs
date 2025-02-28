using FluentValidation;
using RestaurantAutomation.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAutomation.Business.Validators
{
    public class OrderDetailValidator:AbstractValidator<OrderDetail>
    {
        public OrderDetailValidator()
        {
            RuleFor(x => x.OrderID)
            .NotEmpty().WithMessage("Order ID is required.");

            RuleFor(x => x.Order)
                .Must(order => order == null || order.ID != Guid.Empty).WithMessage("If an order is provided, it must be valid.");

            RuleFor(x => x.MenuItemID)
                .NotEmpty().WithMessage("Menu Item ID is required.");

            RuleFor(x => x.MenuItem)
                .Must(menuItem => menuItem == null || menuItem.ID != Guid.Empty).WithMessage("If a menu item is provided, it must be valid.");

            RuleFor(x => x.Quantity)
                .GreaterThan(0).WithMessage("Quantity must be greater than 0.");
        }
    }
}
