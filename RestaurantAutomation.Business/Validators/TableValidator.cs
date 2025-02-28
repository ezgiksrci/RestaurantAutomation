using FluentValidation;
using RestaurantAutomation.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAutomation.Business.Validators
{
    public class TableValidator:AbstractValidator<Table>
    {
        public TableValidator()
        {
            RuleFor(x => x.TableNumber)
            .GreaterThan(0).WithMessage("Table number must be greater than 0.");

            RuleFor(x => x.Status)
                .NotEmpty().WithMessage("Table status cannot be empty.")
                .Must(s => s == "Empty" || s == "Occupied").WithMessage("Table status must be 'Empty' or 'Occupied'.");

            RuleFor(x => x.TableCategory)
                .NotEmpty().WithMessage("Table category cannot be empty.")
                .MinimumLength(3).WithMessage("Table category must be at least 3 characters long.");
        }
    }
}
