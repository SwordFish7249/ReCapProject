using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.CarName).NotEmpty();
            RuleFor(c=>c.CarName).MinimumLength(2);
            RuleFor(c => c.UnitPrice).NotEmpty();
            RuleFor(c => c.UnitPrice).GreaterThan(0);
            RuleFor(c => c.UnitPrice).GreaterThanOrEqualTo(10).When(c => c.Id == 1);
        }
    }
}
