using FluentValidation;
using RestaurantAutomation.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAutomation.Business.Validators
{
    public class OrderValidator:AbstractValidator<Order>
    {
        public OrderValidator()
        {
            RuleFor(x => x.OrderDate)
           .NotEmpty().WithMessage("Order date cannot be empty.")
           .Must(orderDate => orderDate <= DateTime.Now).WithMessage("Order date cannot be in the future.");

            RuleFor(x => x.CustomerID)
                .NotEmpty().WithMessage("Customer ID is required.");

            RuleFor(x => x.TableID)
                .NotEmpty().WithMessage("Table ID is required.");

            RuleFor(x => x.Table)
                .Must(table => table == null || table.TableNumber > 0).WithMessage("If a table is provided, it must be valid.");

            RuleFor(x => x.Payment)
                .Must(payment => payment == null || payment.Amount > 0).WithMessage("If payment is provided, it must have a valid amount.");
        }
    }
}
