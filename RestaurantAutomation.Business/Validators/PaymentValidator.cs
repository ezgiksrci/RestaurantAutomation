using FluentValidation;
using RestaurantAutomation.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAutomation.Business.Validators
{
    public class PaymentValidator:AbstractValidator<Payment>
    {
        public PaymentValidator()
        {
            RuleFor(x => x.Amount)
            .GreaterThan(0).WithMessage("Amount must be greater than 0.");

            RuleFor(x => x.PaymentDate)
                .NotEmpty().WithMessage("Payment date cannot be empty.")
                .Must(paymentDate => paymentDate <= DateTime.Now).WithMessage("Payment date cannot be in the future.");

            RuleFor(x => x.OrderID)
                .NotEmpty().WithMessage("Order ID is required.");

            RuleFor(x => x.Order)
                .Must(order => order == null || order.ID != Guid.Empty).WithMessage("If an order is provided, it must be valid.");
        }
    }
}
