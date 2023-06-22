using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validation
{
    public class StudentValidation : AbstractValidator<Student>
    {
        public StudentValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Имя не должно быть пустым!");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Фамилия не должна быть пустой!");
            RuleFor(x => x.Age).LessThan(100).WithMessage("Возраст должен быть меньше 100");
            RuleFor(x => x.Age).GreaterThan(0).WithMessage("Возраст должен быть больше 0");
            RuleFor(x => x.Course).
                NotEmpty().
                LessThan(5).WithMessage("Курс должен быть меньше 5").
                GreaterThan(0).WithMessage("Курс должен быть больше 0");
        }
    }
}
