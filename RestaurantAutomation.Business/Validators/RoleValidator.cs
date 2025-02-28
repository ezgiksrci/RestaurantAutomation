using FluentValidation;
using RestaurantAutomation.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAutomation.Business.Validators
{
    public class RoleValidator:AbstractValidator<Role>
    {
        public RoleValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Role name cannot be empty");
        }
    }
}
