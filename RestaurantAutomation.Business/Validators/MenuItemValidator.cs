using FluentValidation;
using RestaurantAutomation.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAutomation.Business.Validators
{
    public class MenuItemValidator:AbstractValidator<MenuItem>
    {
        public MenuItemValidator()
        {
            RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Name cannot be empty.")
            .Length(3, 50).WithMessage("Name must be between 3 and 50 characters.");

            RuleFor(x => x.Description)
                .MaximumLength(200).WithMessage("Description cannot exceed 200 characters.");

            RuleFor(x => x.Price)
                .GreaterThan(0).WithMessage("Price must be greater than 0.");

            RuleFor(x => x.CategoryID)
                .NotEmpty().WithMessage("Category ID is required.");

            RuleFor(x => x.Image)
                .Must(image => image == null || image.Length <= 3 * 1024 * 1024) 
                .WithMessage("Image size must not exceed 3MB.");
        }
    }
}
